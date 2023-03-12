using System;
using TechTalk.SpecFlow;

namespace Feb2023
{
    [Binding]
    public class TM_FeatureStepDefinitions
    {
        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create new Time and Material record")]
        public void WhenICreateNewTimeAndMaterialRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
