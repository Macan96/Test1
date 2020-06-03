using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/en");
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void ChromeSearch()
        {
            driver.FindElement(By.Name("q")).SendKeys("Mitto CH");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            var element = driver.FindElement(By.ClassName("TbwUpd NJjxre"));
            Assert.IsTrue(element.Displayed);
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
