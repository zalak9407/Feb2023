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
        //[When(@"I update '([^']*)' on an existing Time and Material record")]
        //public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description)
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"The record should have the updated '([^']*)'")]
        //public void ThenTheRecordShouldHaveTheUpdated(string description)
        //{
        //    throw new PendingStepException();
        //}

        [When(@"I update '([^']*)', '([^']*)', '([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description, string code, string price)
        {
            tmobj.EditTm(driver, description, code, price);

        }

        [Then(@"The record should have the updated '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string description, string code, string price)
        {
            string editedDescription = tmobj.GetEditedDescription(driver);
            string editedCode = tmobj.GetEditedCode(driver);
            string editedPrice = tmobj.GetEditedPrice(driver);

            Assert.That(editedDescription == description, "Actual description and expected description do not match.");
            Assert.That(editedCode == code, "Actual code and expected code do not match.");
            Assert.That(editedPrice == price, "Actual price and expected price do not match.");

        }
        }
    }
