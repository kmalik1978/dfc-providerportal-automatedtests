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
    [NUnit.Framework.DescriptionAttribute("Search Provider")]
    public partial class SearchProviderFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SearchProvider.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search Provider", "\tIn order to view provider details\r\n\tAs a provider\r\n\tI want to be able to search " +
                    "for providers", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Search a Provider")]
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
        public virtual void SearchAProvider(string profile, string environment, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BrowserStack"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search a Provider", null, @__tags);
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
 testRunner.Given(string.Format("I have navigated to the Home page using {0} and {1}", profile, environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And("I login as admin with user and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.Given("I have searched for UKPRN \"10002815\" and clicked search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("I click to view my courses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

