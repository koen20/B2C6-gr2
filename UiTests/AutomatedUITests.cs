using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
        public void Articles()
        {
            chromeDriver.Navigate()
                .GoToUrl("https://b2c6-dev.azurewebsites.net/Articles");
            Assert.AreEqual("Artikelen catalogus - B2C6_gr2", chromeDriver.Title);
        }

        [TestMethod()]
        public void ArticleSearch()
        {
            chromeDriver.Navigate()
                .GoToUrl("https://b2c6-dev.azurewebsites.net/Articles");
            chromeDriver.FindElement(By.Id("searchField")).SendKeys("Stoel");
            chromeDriver.FindElement(By.ClassName("btn")).Click();
            WebDriverWait wait = new WebDriverWait(chromeDriver, new System.TimeSpan(0, 1, 0));
            var text = chromeDriver.FindElement(By.ClassName("grid-container"));
            Assert.IsTrue(text.Text.Contains("Stoel"));
        }

        [TestMethod()]
        public void ArticleSort()
        {
            chromeDriver.Navigate()
                .GoToUrl("https://b2c6-dev.azurewebsites.net/Articles");
            chromeDriver.FindElement(By.Id("sort-point")).Click();
            Assert.AreEqual("Artikelen catalogus - B2C6_gr2", chromeDriver.Title);
        }
    }
}
