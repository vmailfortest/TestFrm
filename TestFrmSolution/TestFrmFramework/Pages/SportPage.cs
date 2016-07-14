using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrmFramework.Pages
{
    public class SportPage
    {
        private IWebDriver driver;

        public SportPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//*[@class='primary-nav__items']/li[4]/a/span")]
        private IWebElement FootballLink = null;

        public bool IsOn()
        {
            if (FootballLink.Text.Equals("Football"))
            {
                return true;
            }
            return false;
        }
    }
}
