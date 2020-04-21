using NUnit.Framework;
using NUnitAutomationProject.Pages;
using OpenQA.Selenium;

namespace NUnitAutomationProject.Tests.GoogleSearchTest
{
    [TestFixture]
    class GoogleSearchTest : BaseTest
    {

        [Test]
        public void SubmitSearchRequestAndCheckSearchResults()
        {
            GoogleSearchPage searchPage = new GoogleSearchPage(driver);
            string textToSearch = "Selenium IDE export to C#";
            string expectedText = "Selenium IDE";

            searchPage.EnterTextIntoSearchField(textToSearch);
            searchPage.SubmitSearchRequest();
            string actualText = searchPage.GetTextFromResultsById(5);

            Assert.IsTrue(actualText.Contains(expectedText));
        }
    }
}