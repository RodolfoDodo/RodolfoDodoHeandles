using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;

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
            ChromeDriver c = new ChromeDriver();
            c.Navigate().GoToUrl("https://www.google.com.br/");
            Assert.AreEqual("Google", c.Title);
            Thread.Sleep(5000);
            c.Dispose();
        }
    }
}