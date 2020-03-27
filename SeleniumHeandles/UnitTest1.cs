using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace SeleniumHeandles
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            String url = "http://www.google.com";
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>() { "headless" });

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            ChromeDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Navigate().GoToUrl(url);
            Assert.AreEqual("Google", driver.Title);
        }
    }
}