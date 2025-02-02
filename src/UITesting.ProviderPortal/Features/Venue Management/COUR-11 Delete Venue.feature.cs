﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UITesting.ProviderPortal.Features.VenueManagement
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("COUR-11 Delete Venue")]
    public partial class COUR_11DeleteVenueFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "COUR-11 Delete Venue.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "COUR-11 Delete Venue", "\tIn order to manage my venues\r\n\tAs a provider\r\n\tI want to be able to delete venue" +
                    "s", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("I have accessed course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I login as admin with user and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.Then("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.Given("I have searched for UKPRN \"10007348\" and clicked search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.When("I click to view my courses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Given("I have navigated to the Your Venues Pages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.Then("I should be able to see a Edit and Delete Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-11 Validate after clicking Delete button")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_11ValidateAfterClickingDeleteButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-11 Validate after clicking Delete button", null, new string[] {
                        "CI"});
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 16
 testRunner.Given("I have searched for \"TestDeleteVenueWithCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.And("clicked the delete link for \"TestDeleteVenueWithCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("I should be able to see a confirm delete button and a cancel link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-11 Click cancel to stop deletion of venue")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_11ClickCancelToStopDeletionOfVenue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-11 Click cancel to stop deletion of venue", null, new string[] {
                        "CI"});
#line 21
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 22
 testRunner.Given("I have searched for \"TestDeleteVenueNoCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("clicked the delete link for \"TestDeleteVenueNoCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("I have clicked the cancel link for \"TestDeleteVenueNoCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("I should be able to see a Edit and Delete Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.And("Venue \"TestDeleteVenueNoCourse\" should not be deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-11 Delete Venue with no course")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_11DeleteVenueWithNoCourse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-11 Delete Venue with no course", null, new string[] {
                        "CI"});
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 30
 testRunner.Given("I have searched for \"TestDeleteVenueNoCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.And("clicked the delete link for \"TestDeleteVenueNoCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("I should be able to see a confirm delete button and a cancel link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.When("I have clicked the confirm delete button for \"TestDeleteVenueNoCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("the venue should be deleted \"TestDeleteVenueNoCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.And("a delete message should be displayed \"Venue TestDeleteVenueNoCourse has been dele" +
                    "ted\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-11 Delete Venue with course associated with Venue")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_11DeleteVenueWithCourseAssociatedWithVenue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-11 Delete Venue with course associated with Venue", null, new string[] {
                        "CI"});
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 39
 testRunner.Given("I have searched for \"TestDeleteVenueWithCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
 testRunner.And("there is a course associated with the venue \"TestDeleteVenueWithCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("clicked the delete link for \"TestDeleteVenueWithCourse\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.Then("the venue \"TestDeleteVenueWithCourse\" should not be deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.And("a message should be displayed \"There are live courses associated with this venue." +
                    " Please delete these courses or assign a different venue to the courses before d" +
                    "eleting the venue\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

