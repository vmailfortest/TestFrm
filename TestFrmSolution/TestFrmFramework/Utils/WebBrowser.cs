using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrmFramework.Utils
{
    public class WebBrowser
    {
        public static string Browser = ConfigurationManager.AppSettings["Browser"];

        public static IWebDriver GetDriver()
        {
            DesiredCapabilities caps;
            IWebDriver driver;

            switch (Browser)
            {
                case "Chrome":
                    caps = DesiredCapabilities.Chrome();
                    driver = new RemoteWebDriver(new Uri(ConfigurationManager.AppSettings["SeleniumServerUrl"]), caps);
                    driver.Manage().Window.Maximize();
                    return driver;
                case "Firefox":
                    caps = DesiredCapabilities.Firefox();
                    driver = new RemoteWebDriver(new Uri(ConfigurationManager.AppSettings["SeleniumServerUrl"]), caps);
                    driver.Manage().Window.Maximize();
                    return driver;
                case "IE":
                    caps = DesiredCapabilities.InternetExplorer();
                    driver = new RemoteWebDriver(new Uri(ConfigurationManager.AppSettings["SeleniumServerUrl"]), caps);
                    driver.Manage().Window.Maximize();
                    return driver;
            }

            throw new Exception("Invalid browser name in appSettings. Should be one of: Chrome, Firefox, IE.");
        }
    }
}
