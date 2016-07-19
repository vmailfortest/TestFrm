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

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            XmlConfigurator.Configure();

            TestHelper.Logger.Debug("Starting driver.");
            driver = WebBrowser.GetDriver();

            TestHelper.Logger.Debug("Starting TestClass: " + TestContext.CurrentContext.Test.ClassName);
        }

        [SetUp]
        public void SetUp()
        {
            TestHelper.Logger.Debug("Starting test: " + TestContext.CurrentContext.Test.Name);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            TestHelper.Logger.Debug("Quit driver.");
            driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            TestHelper.Logger.Debug("Finished test: " + TestContext.CurrentContext.Test.Name);

            //bool testResult = TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed;
            //if (testResult == true)
            //{
            //    TestHelper.CreateScreenshot(driver, TestContext.CurrentContext.Test.Name);
            //    TestHelper.Logger.Info($"Screenshot is captured");
            //}
        }

        protected void UITest(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                TestHelper.Logger.Error(TestContext.CurrentContext.Test.ClassName + " > "
                    + TestContext.CurrentContext.Test.Name + "\r\n"
                    + ex.Message);

                TestHelper.CreateScreenshot(driver, TestContext.CurrentContext.Test.Name);

                throw;
            }
        }

    }
}
