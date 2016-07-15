using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrmFramework.Pages
{
    public class SportPage : PageBase
    {
        public SportPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = ".//*[@class='primary-nav__items']/li[4]/a/span")]
        private IWebElement FootballLink = null;

        public bool IsAt()
        {
            if (FootballLink.Text.Equals("Football"))
            {
                return true;
            }
            return false;
        }
    }
}
