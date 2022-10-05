using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using AutomationPracticeFramework.Pages;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class SearchSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        [Given(@"user enters '(.*)' search term")]
        public void GivenUserEntersSearchTerm(string term)
        {
            ut.EnterTextInElement(hp.searchField, term);
        }

        [When(@"user submit the search")]
        public void WhenUserSubmitTheSearch()
        {
            ut.ClickOnElement(hp.searchBtn);
        }

        [Then(@"results for '(.*)' term are displayed")]
        public void ThenResultsForTermAreDisplayed(string term)
        {
            SearchResultsPage srp = new SearchResultsPage(Driver);
            Assert.That(ut.ReturnTextFromElement(srp.searchResult), Does.Contain(term), "Wrong Search result");
        }
    }
}
