using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFrmFramework.Pages;
using TestFrmFramework.Utils;

namespace TestFrmSolution.Tests
{
    [TestFixture]
    //[Parallelizable]
    public class BbcWebsiteTests : TestBase
    {
        [SetUp]
        public static void SetUp()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["BbcUrl"]);
        }

        [Test]
        public void WelcomeTextIsPresented()
        {
            UITest(() =>
            {
                var homePage = new HomePage(driver);

                string expectedText = "Welcome to BBC.com";

                string actualText = homePage.GetWelcomeText();

                //actualText.Should().Be(expectedText);
                actualText.Should().Be(expectedText, "Welcome text on home page is absent or incorrect");
            });
        }

        [Test]
        public void MainMenuPresentedOnSport()
        {
            UITest(() =>
            {
                var homePage = new HomePage(driver);

                homePage.ClickSportLink();

                var sportPage = new SportPage(driver);

                sportPage.IsAt().Should().BeTrue("Main menu on sport page is absent or incorrect");
            });
        }
    }
}
