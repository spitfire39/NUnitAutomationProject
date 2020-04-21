using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitAutomationProject.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void TypeText(string element, string text)
        {
            try
            {
                driver.FindElement(By.Name(element)).SendKeys(text);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected void SubmitSearch(string element, string elementToWaitfor)
        {
            try
            {
                driver.FindElement(By.Name(element)).Submit();
                WaitForElementExists(By.XPath(elementToWaitfor), 5);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected IWebElement WaitForElementExists(By locator, int maxSeconds)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(maxSeconds)).Until(ExpectedConditions.ElementExists(locator));
        }
    }
}