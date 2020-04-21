using NUnit.Framework;
using NUnitAutomationProject.Pages;

namespace NUnitAutomationProject.Tests.GoogleSearchTest
{
    [TestFixture]
    class GoogleSearchTest : BaseTest
    {
        
        [Test]
        public void SubmitSearchRequestAndCheckSearchResults()
        {
            var searchPage = new GoogleSearchPage(driver);
            searchPage.EnterTextIntoSearchField("Selenium IDE export to C#");
            var resultsPage = searchPage.SubmitSearchRequest();
            Assert.True(resultsPage.getTextFromResultsById(5, "Selenium IDE"));
        }
    }
}