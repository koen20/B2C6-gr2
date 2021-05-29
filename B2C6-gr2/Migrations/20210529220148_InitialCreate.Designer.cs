﻿// <auto-generated />
using B2C6_gr2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace B2C6_gr2.Migrations
{
    [DbContext(typeof(B2C6_gr2Context))]
    [Migration("20210529220148_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("B2C6_gr2.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtikelNaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArtikelPunten")
                        .HasColumnType("int");

                    b.Property<int>("ArtikelSoortId")
                        .HasColumnType("int");

                    b.Property<string>("Serienummer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Article");
                });
#pragma warning restore 612, 618
        }
    }
}
