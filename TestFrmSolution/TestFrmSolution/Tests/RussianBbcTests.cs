using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFrmFramework.Pages;

namespace TestFrmSolution.Tests
{
    [TestClass]
    public class RussianBbcTests
    {
        private static IWebDriver driver;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            driver = new ChromeDriver(@"c:\temp\");
            driver.Navigate().GoToUrl("http://www.bbc.com/russian");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void MainPageIsOpened()
        {
            var rusHomePage = new RusHomePage(driver);

            rusHomePage.IsAt().Should().BeTrue();
        }
    }
}
