using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrmFramework.Utils
{
    public class TestHelper
    {
        public static void CreateScreenshot(IWebDriver driver, string testName)

        {
            string screenshotPath = ConfigurationManager.AppSettings["Screenshots"];

            string screenshotName = "scr_"
                + DateTime.Now.ToString("yyMMdd_HHmmss")
                + "_"
                + testName
                + ".png";

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(screenshotPath + screenshotName, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
