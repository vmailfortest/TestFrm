﻿using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestFrmFramework.Pages;
using TestFrmFramework.Utils;

namespace TestFrmSolution.Tests
{
    [TestFixture]
    public class RussianBbcTests : TestBase
    {
        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["RussianBbcUrl"]);
        }

        [Test]
        public void MainPageIsOpened()
        {
            var rusHomePage = new RusHomePage(driver);

            rusHomePage.IsAt().Should().BeTrue();
        }
    }
}
