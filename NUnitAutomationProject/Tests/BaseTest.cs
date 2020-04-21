using NUnit.Framework;
using NUnitAutomationProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitAutomationProject.Tests
{
    abstract class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://google.com");
            Console.WriteLine("Opened URL.");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
            Console.WriteLine("Browser closed.");
        }
    }
}