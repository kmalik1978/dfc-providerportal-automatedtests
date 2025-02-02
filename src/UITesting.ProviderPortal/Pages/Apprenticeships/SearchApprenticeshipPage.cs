﻿using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Apprenticeships
{
    public class SearchApprenticeshipPage : BasePage
    {
        private static String PAGE_TITLE = "Find apprenticeship";
        private By searchInput = By.Id("ApprenticeshipSearchTerm");
        private By searchButton = By.Id("searchApprenticeships");
        private By errorMsg = By.XPath(".//*[@id='ApprenticeshipsSearchResultContainer']/div/div");
        private By resultReturned = By.XPath(".//*[@id='ApprenticeshipsSearchResultContainer']/div/div[1]/span");
        private By apprenticeshipsName = By.XPath(".//*[@id='ApprenticeshipsSearchResultContainer']/div/div[2]/div/h3");
        private By level = By.XPath(".//*[@id='ApprenticeshipsSearchResultContainer']/div/div[2]/div/p[1]/span");
        private By selectLink = By.LinkText("Choose this apprenticeship");
        private By frameworkLabel = By.XPath(".//*[@id='ApprenticeshipsSearchResultContainer']/div/div[2]/div/h3/span");

        public SearchApprenticeshipPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public SearchApprenticeshipPage EnterSearchTerm(string searchTerm)
        {
            FormCompletionHelper.EnterText(searchInput, searchTerm);
            FormCompletionHelper.ClickElement(searchButton);
            PageInteractionHelper.WaitForPageToLoad();
            return new SearchApprenticeshipPage(webDriver);
        }

        public SearchApprenticeshipPage NoResultsMsg()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.VerifyElementPresent(errorMsg);
            return new SearchApprenticeshipPage(webDriver);
        }

        public SearchApprenticeshipPage ResultsReturned()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.VerifyElementPresent(resultReturned);            
            return new SearchApprenticeshipPage(webDriver);
        }

        public SearchApprenticeshipPage ConfirmApprenticeshipDetail()
        {
            FormCompletionHelper.VerifyElementPresent(apprenticeshipsName);
            FormCompletionHelper.VerifyElementPresent(level);
            FormCompletionHelper.VerifyElementPresent(selectLink);
            return new SearchApprenticeshipPage(webDriver);
        }

        public SearchApprenticeshipPage FrameworkLabel()
        {
            FormCompletionHelper.VerifyElementPresent(frameworkLabel);
            return new SearchApprenticeshipPage(webDriver);
        }

        public AddApprenticeshipPage SelectApprenticeship()
        {
            FormCompletionHelper.ClickElement(selectLink);
            return new AddApprenticeshipPage(webDriver);
        }

    }
}