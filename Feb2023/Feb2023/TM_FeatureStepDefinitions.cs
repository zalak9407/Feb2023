using Feb2023.pages;
using Feb2023.utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Feb2023
{
    [Binding]
    public class TM_FeatureStepDefinitions : Commondriver
    {
        HomePage homeobj = new HomePage();
        LoginPage loginobj = new LoginPage();
        TMPage tmobj = new TMPage();

        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();

            
            loginobj.loginmethod(driver);

        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homeobj.GoToTmPage(driver);
        }

        [When(@"I create new Time and Material record")]
        public void WhenICreateNewTimeAndMaterialRecord()
        {
            tmobj.CreateTm(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newcode = tmobj.getcode(driver);
            string newdes = tmobj.getdescription(driver);
            string newprice = tmobj.getprice(driver);

            Assert.That(newcode == "feb2023", "Actual code and exxpected code do not match");
            Assert.That(newdes == "june2023", "Actual code and expected code do not match");
            Assert.That(newprice == "12", "Actual code and expected code do not match");
        }
    }
}
