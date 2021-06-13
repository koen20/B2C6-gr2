using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2C6_gr2Tests
{
    [TestClass]
    public class AutomatedUITests : IDisposable
    {
        private readonly IWebDriver chromeDriver;
        public AutomatedUITests()
        {
            //chromeDriver = new ChromeDriver(@"C:\Users\koenh\source\repos\B2C6-gr2\B2C6-gr2Tests\");
            chromeDriver = new ChromeDriver();
        }
        public void Dispose()
        {
            chromeDriver.Quit();
            chromeDriver.Dispose();
        }

        [TestMethod()]
        public void Privacy()
        {
            chromeDriver.Navigate()
                .GoToUrl("https://b2c6-dev.azurewebsites.net/");
            //Assert.Equals("", _driver.Title);
            Assert.IsNotNull(chromeDriver.Title);
        }

        [TestMethod()]
        public void Articles()
        {
            chromeDriver.Navigate()
                .GoToUrl("https://b2c6-dev.azurewebsites.net/Articles");
            //Assert.Equals("", _driver.Title);
            Assert.AreEqual("Artikelen catalogus - B2C6_gr2", chromeDriver.Title);
        }
    }
}
