using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrmFramework.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//*[@class='module__title']/span")]
        private IWebElement WelcomeText = null;

        [FindsBy(How = How.XPath, Using = ".//*[@class='orb-nav-sport']/a")]
        private IWebElement MenuLinkSport = null;

        public string GetWelcomeText()
        {
            return WelcomeText.Text;
        }

        public void ClickSportLink()
        {
            MenuLinkSport.Click();
        }
    }
}
