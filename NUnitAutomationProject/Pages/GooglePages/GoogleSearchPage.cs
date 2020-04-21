using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NUnitAutomationProject.Pages
{
    public class GoogleSearchPage<T> : BasePage<T>
    {
        public GoogleSearchPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.Name, Using = "q")]
        protected IWebElement SearchField { get; set; }

        //// this method enters text into search field
        public GoogleSearchPage<T> EnterTextIntoSearchField(string text)
        {
            TypeText(SearchField, text);
            return this;
        }

        // this method submites search request 
        public GoogleSearchPage<T> SubmitSearchRequest()
        {
            SubmitSearch(SearchField);
            return new GoogleSearchPage<T>(driver);
        }
    }
}