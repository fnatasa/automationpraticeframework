using System;
using TechTalk.SpecFlow;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class FooterSteps : Base
    {
        FooterPage fp = new FooterPage(Driver);

        [When(@"user clicks on '(.*)' option")]
        public void WhenUserClicksOnOption(string link)
        {
            fp.ClickOnInformationLink(link);
        }

        [Then(@"correct '(.*)' is displayed")]
        public void ThenCorrectIsDisplayed(string p0)
        {
        }
    }
}