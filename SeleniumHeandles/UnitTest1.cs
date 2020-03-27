using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumHeandles
{
    public class Tests
    {
        public IWebDriver driver;
        private string baseURL;
        public string screenshotsPasta;
        int contador = 1;


        //Método para capturar screenshot da tela
        public void Screenshot(IWebDriver driver, string screenshotsPasta)
        {
            ITakesScreenshot camera = driver as ITakesScreenshot;
            Screenshot foto = camera.GetScreenshot();
            foto.SaveAsFile(screenshotsPasta, ScreenshotImageFormat.Png);
        }

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            baseURL = "https://www.google.com.br";
            screenshotsPasta = @"C:\Users\Rodolfo\source\repos\SeleniumHeandles\SeleniumHeandles";
        }

        public void capturaImagem()
        {
            Screenshot(driver, screenshotsPasta + "Imagem_" + contador++ + ".png");
            Thread.Sleep(500);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [Test]

        public void NomeDoTeste()
        {
            driver.Navigate().GoToUrl(baseURL + "/intl/pt-BR/about/");
            Thread.Sleep(1000);
            capturaImagem();
            Thread.Sleep(1000);
        }
    }
}