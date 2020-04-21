using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace NUnitAutomationProject.Pages
{
    public class GoogleSearchPage
    {
        IWebDriver driver;
        
        public GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // This method enters text into Search field
        public GoogleSearchPage EnterTextIntoSearchField(string text)
        {
            driver.FindElement(By.Name("q")).SendKeys(text);
            return this;
        }

        // This method submites search request 
        public GoogleResultsPage SubmitSearchRequest()
        {
            driver.FindElement(By.Name("q")).Submit();
            return new GoogleResultsPage(driver);
        }
    }
}