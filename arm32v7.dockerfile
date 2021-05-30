FROM alpine AS builder

# Download QEMU, see https://github.com/docker/hub-feedback/issues/1261
#ENV QEMU_URL https://github.com/balena-io/qemu/releases/download/v3.0.0%2Bresin/qemu-3.0.0+resin-arm.tar.gz
ENV QEMU_URL https://github.com/balena-io/qemu/releases/download/v5.2.0%2Bbalena4/qemu-5.2.0.balena4-arm.tar.gz
RUN apk add curl && curl -L ${QEMU_URL} | tar zxvf - -C . --strip-components 1

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim-arm32v7 AS base

COPY --from=builder qemu-arm-static /usr/bin

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim-arm32v7 AS build
COPY --from=builder qemu-arm-static /usr/bin
WORKDIR /src
COPY ["B2C6-gr2/B2C6-gr2.csproj", "B2C6-gr2/"]
RUN dotnet restore "B2C6-gr2/B2C6-gr2.csproj"
COPY . .
WORKDIR "/src/B2C6-gr2"
RUN dotnet build "B2C6-gr2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "B2C6-gr2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "B2C6-gr2.dll"]