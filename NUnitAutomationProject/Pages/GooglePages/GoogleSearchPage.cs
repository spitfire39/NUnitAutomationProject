using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NUnitAutomationProject.Pages
{
    public class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver) : base(driver) { }

        static string SearchField = "q";
        static string Results = "//div[@class='r']//h3";

        // this method enters text into search field
        public GoogleSearchPage EnterTextIntoSearchField(string text)
        {
            TypeText(SearchField, text);
            return this;
        }

        // this method submites search request 
        public GoogleSearchPage SubmitSearchRequest()
        {
            SubmitSearch(SearchField, Results);
            return new GoogleSearchPage(driver);
        }

        // This method gets list of search results, from list takes row by row ID, and checks for text presence
        public string GetTextFromResultsById(int id)
        {
            IList<IWebElement> resultLinks = driver.FindElements(By.XPath(Results));
            //return resultLinks.ElementAt(id).Text.Contains(text);
            return resultLinks.ElementAt(id).Text;

        }
    }
}