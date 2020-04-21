using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NUnitAutomationProject.Pages
{
    public class GoogleResultsPage
    {
        IWebDriver driver;

        public GoogleResultsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // This method gets list of search results, from list takes row by row ID, and checks for text presence
        public bool getTextFromResultsById(int id, string text)
        {
            IList<IWebElement> resultLinks = driver.FindElements(By.XPath("//div[@class='r']//h3")); // css: #center_col .g .rc .r
            return resultLinks.ElementAt(id).Text.Contains(text);
        }
    }
}