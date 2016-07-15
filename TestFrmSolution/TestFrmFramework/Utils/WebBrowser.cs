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

            switch (Browser)
            {
                case "Chrome":
                    caps = DesiredCapabilities.Chrome();
                    return new RemoteWebDriver(new Uri(ConfigurationManager.AppSettings["SeleniumServerUrl"]), caps);
                case "Firefox":
                    caps = DesiredCapabilities.Firefox();
                    return new RemoteWebDriver(new Uri(ConfigurationManager.AppSettings["SeleniumServerUrl"]), caps);
                case "IE":
                    caps = DesiredCapabilities.InternetExplorer();
                    return new RemoteWebDriver(new Uri(ConfigurationManager.AppSettings["SeleniumServerUrl"]), caps);
            }

            throw new Exception("Invalid browser name in appSettings. Should be one of: Chrome, Firefox, IE.");
        }
    }
}
