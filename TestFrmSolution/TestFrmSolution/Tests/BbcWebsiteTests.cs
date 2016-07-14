using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFrmFramework.Pages;

namespace TestFrmSolution.Tests
{
    [TestClass]
    public class BbcWebsiteTests
    {
        private static IWebDriver driver;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            driver = new ChromeDriver(@"c:\temp\");
            driver.Navigate().GoToUrl("http://bbc.com");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void WelcomeTextIsPresented()
        {
            var homePage = new HomePage(driver);

            string expectedText = "Welcome to BBC.com";

            string actualText = homePage.GetWelcomeText();

            actualText.Should().Be(expectedText);
        }

        [TestMethod]
        public void MainMenuPresentedOnSport()
        {
            var homePage = new HomePage(driver);

            homePage.ClickSportLink();

            var sportPage = new SportPage(driver);
            sportPage.IsOn().Should().BeTrue();
        }
    }
}
