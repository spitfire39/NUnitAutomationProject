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
            //GoogleSearchPage searchPage = new GoogleSearchPage(driver);
            var searchPage = new GoogleSearchPage<T>(driver);
            searchPage.EnterTextIntoSearchField("Selenium IDE export to C#");
            var resultsPage = searchPage.SubmitSearchRequest();
            //Assert.True(resultsPage.GetTextFromResultsById(5, "Selenium IDE"));
        }
    }
}