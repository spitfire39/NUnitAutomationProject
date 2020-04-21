using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitAutomationProject.Pages
{
    public abstract class BasePage<T>
    {
        protected IWebDriver driver;
        //protected IWait<T> wait;

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void TypeText(IWebElement element, string text)
        {
            try
            {
                element.SendKeys(text);
            }
            catch(NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected void SubmitSearch(IWebElement element)
        {
            try
            {
                element.Submit();
                //wait.Until.element
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
