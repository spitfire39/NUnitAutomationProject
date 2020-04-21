using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NUnitAutomationProject.Pages
{
    public class GoogleResultsPage<T> : BasePage<T>
    {
        public GoogleResultsPage(IWebDriver driver) : base(driver) { }

        // This method gets list of search results, from list takes row by row ID, and checks for text presence
        public bool GetTextFromResultsById(int id, string text)
        {
            IList<IWebElement> resultLinks = driver.FindElements(By.XPath("//div[@class='r']//h3")); // css: #center_col .g .rc .r
            return resultLinks.ElementAt(id).Text.Contains(text);
        }
    }
}