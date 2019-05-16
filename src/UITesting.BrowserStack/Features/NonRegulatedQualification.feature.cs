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
namespace UITesting.BrowserStack.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Non Regulated Qualification Search")]
    public partial class NonRegulatedQualificationSearchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NonRegulatedQualification.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Non Regulated Qualification Search", "\tIn order to select a Non Reg Provision\r\n\tAs a provider\r\n\tI want to be able to ad" +
                    "d a non reg provision as my published course", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Non Regulated Provision using SSA")]
        [NUnit.Framework.CategoryAttribute("BrowserStack")]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome74win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome73win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome72win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome70win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome74win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome73win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome74win8", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome73win8", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome74win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome73win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome74macos", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome73macos", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox66win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox65win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox66win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox65win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox66win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox65win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox66osx", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox65osx", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "ie11win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "ie11win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "ie11win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "edge18win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "edge17win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "edge16win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "safari12macos", null)]
        public virtual void AddNonRegulatedProvisionUsingSSA(string profile, string environment, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BrowserStack"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Non Regulated Provision using SSA", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.Given(string.Format("I have navigated to the Home page using {0} and {1}", profile, environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("I login as admin with user and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Given("I have searched for UKPRN \"10002815\" and clicked search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.When("I Navigate to Regulated Qualifications page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And("I have selected Non Regulated Option and Clicked Next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("the Unregulated courses page should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.Given("I have clicked  I dont know z code link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.Then("Unknown Z code page should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("I Select First Level and Second Level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("I click the Add this Provision link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("add course page should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.Given("I have specified who the course is for Semi-qualified (people)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.And("I have entered the entry requirements 1. Industry experience", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I have entered what the student will learn Student will learn about the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("I click Next Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("add course run should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.When("I enter the following in the course name field Course test for non regulated cour" +
                    "se", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.When("I select start date Defined Start Date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And("I enter 01 in the Day field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I enter 03 in the Month field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("I enter 2021 in the Year field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("I enter the following in the cost field 2000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("I select duration length 12", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("I select duration unit Weeks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("I select the first venue in the venues list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("I click Publish", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("the course should be listed in the Your courses page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
