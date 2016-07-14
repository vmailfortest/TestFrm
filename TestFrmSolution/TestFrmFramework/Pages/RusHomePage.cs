using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrmFramework.Pages
{
    public class RusHomePage
    {
        private IWebDriver driver;

        public RusHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(.//*[@class='navigation-wide-list__link'])[1]/span")]
        private IWebElement MainPageText = null;

        public bool IsAt()
        {
            if (MainPageText.Text.Equals("Главная"))
            {
                return true;
            }
            return false;
        }
    }
}
