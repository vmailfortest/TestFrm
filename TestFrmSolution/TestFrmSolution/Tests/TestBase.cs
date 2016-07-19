using log4net;
using log4net.Config;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestFrmFramework.Utils;

namespace TestFrmSolution.Tests
{
    public class TestBase
    {
        public static IWebDriver driver;
        public static ILog logger = LogManager.GetLogger(typeof(RussianBbcTests));

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            DOMConfigurator.Configure();

            logger.Info("Starting driver.");
            driver = WebBrowser.GetDriver();

            logger.Info("Starting TestClass: " + TestContext.CurrentContext.Test.ClassName);
        }

        [SetUp]
        public void SetUp()
        {
            logger.Info("Starting test: " + TestContext.CurrentContext.Test.Name);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            logger.Info("Quit driver.");
            driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            logger.Info("Finished test: " + TestContext.CurrentContext.Test.Name);

            bool testResult = TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed;

            if (testResult == true)
            {
                TestHelper.CreateScreenshot(driver, TestContext.CurrentContext.Test.Name);

                logger.Info($"Screenshot is captured");
            }

        }
    }
}
