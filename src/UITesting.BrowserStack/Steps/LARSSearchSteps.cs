﻿using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UITesting.Framework.Helpers;
using UITesting.BrowserStack.TestSupport;
using UITesting.BrowserStack.Pages;
using UITesting.ProviderPortal.Pages;
using System.Linq;

namespace UITesting.BrowserStack.Steps
{
    [Binding]
    public class LARSSearchSteps
    {
        private IWebDriver _driver;
        public static IWebDriver webDriver;
        readonly BrowserStackDriver _bsDriver;

        
        public LARSSearchSteps()
        {

            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("Regression"))
            {
                _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
            }
            else
            {
                webDriver = (IWebDriver)ScenarioContext.Current["_driver"];
            }    
        }


        [Given(@"I have navigated to the landing page for (.*) and (.*)")]
        public void GivenIAmOnTheLandingPage(string profile, string environment)
        {
            webDriver = _bsDriver.Init(profile, environment);
            webDriver.Navigate().GoToUrl(Configurator.GetConfiguratorInstance().GetBaseUrl());
            PageInteractionHelper.SetDriver(webDriver);
        }


        [Given(@"I have navigated to the landing page")]
        public void GivenIAmOnTheLandingPage2()
        {
            webDriver.Navigate().GoToUrl(Configurator.GetConfiguratorInstance().GetBaseUrl());
        }


        //[When(@"I do a LARS Search for (.*)"), Scope(Tag = "BrowserStack")]
        //public void WhenISearchForBrowserStack(string searchTerm)
        //{
        //        LARSSearchPage larsSearchPage = new LARSSearchPage(webDriver);
        //        larsSearchPage.EnterSearchTextAndSubmit(searchTerm);
        //        Thread.Sleep(10);
        //}


        [When(@"I do a LARS Search for (.*)")]
        public void WhenISearchFor(string searchTerm)
        {
            LARSSearchPage larsSearchPage = new LARSSearchPage(webDriver);
            larsSearchPage.EnterSearchTextAndSubmit(searchTerm);
            Thread.Sleep(10);
        }


        //[Then(@"I should see title (.*)"), Scope(Tag = "BrowserStack")]
        //public void ThenIShouldSeeTitleBrowserstack(string searchTerm)
        //{
        //    LARSSearchPage larsSearchPage = new LARSSearchPage(webDriver);
        //    larsSearchPage.ConfirmLARSdisplayed(searchTerm);
        //}


        [Then(@"I should see title (.*)")]
        public void ThenIShouldSeeTitle(string searchTerm)
        {
            LARSSearchPage larsSearchPage = new LARSSearchPage(webDriver);
            larsSearchPage.ConfirmLARSdisplayed(searchTerm);
        }


        [Given(@"I navigate to GOV\.UK home page")]
        public void GivenINavigateToGOV_UKHomePage()
        {
            webDriver.Navigate().GoToUrl("https://www.gov.uk");
        }


        [When(@"I search for (.*)")]
        public void SearchForText(string searchText)
        {
            WelcomeToGovUkPage welcomeToGovUkPage = new WelcomeToGovUkPage(webDriver);
            welcomeToGovUkPage.EnterSearchTextAndSubmit(searchText);
        }


        [When(@"I click on DFE link")]
        public void ClickOnDfeLink()
        {
            SearchResultsPage searchResultsPage = new SearchResultsPage(webDriver);
            searchResultsPage.ClickDfeLink();
        }


        [Then(@"I should be on (.*) home page")]
        public void ShouldBeOnDfeHomePage(string onPage)
        {
            PageInteractionHelper.VerifyPageHeading(By.TagName("h1"), onPage);
        }

    }
}