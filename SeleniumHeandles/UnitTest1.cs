using NUnit.Framework;
using OpenQA.Selenium.Chrome;

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
            c.Dispose();
        }
    }
}