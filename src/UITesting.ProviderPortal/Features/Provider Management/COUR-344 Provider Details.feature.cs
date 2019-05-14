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
namespace UITesting.ProviderPortal.Features.ProviderManagement
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("COUR-344 Provider Details")]
    public partial class COUR_344ProviderDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "COUR-344 Provider Details.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "COUR-344 Provider Details", "\tAs a Provider Super User\r\n\tI need to view my provider details\r\n\tso that I can ch" +
                    "eck that these are correct", ProgrammingLanguage.CSharp, ((string[])(null)));
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
 testRunner.And("I login as provider admin with Provider.10033145@gmail.com and SITtesting123", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.Then("I am logged in as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-493 View Provider Details")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_493ViewProviderDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-493 View Provider Details", null, new string[] {
                        "CI"});
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 13
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Alias")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_Alias()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Alias", null, new string[] {
                        "CI"});
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 18
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("I enter alias Test Alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.And("I click Save on Add provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Alias Max Chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_AliasMaxChars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Alias Max Chars", null, new string[] {
                        "CI"});
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 26
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("I enter alias ALL TRAINING TAKES PLACE 1N THE WORK PLACE. WE WORK WITH OVER 3501 " +
                    "EMPLOYERS ACROSS WHOLE OF ENGLAND", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.And("I click Save on Add provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Alias Special Chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_AliasSpecialChars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Alias Special Chars", null, new string[] {
                        "CI"});
#line 33
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 34
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("I enter alias 1234567890-= !\"£$%^&*()_+{}:\'#;@~/.,?> < ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.And("I click Save on Add provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Alias Over Max Chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_AliasOverMaxChars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Alias Over Max Chars", null, new string[] {
                        "CI"});
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 42
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("I enter alias ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 " +
                    "EMPLOYERS ACROSS WHOLE OF ENGLAND.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.And("I click Save on Add provider details page leading to error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Alias Non ASCII")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_AliasNonASCII()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Alias Non ASCII", null, new string[] {
                        "CI"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 50
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("I enter alias 我想输入文字", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("I click Save on Add provider details page leading to error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Overview")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_Overview()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Overview", null, new string[] {
                        "CI"});
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 58
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then("I enter overview Provider Overview Testing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.And("I click Save on Add provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Overview Max Chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_OverviewMaxChars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Overview Max Chars", null, new string[] {
                        "CI"});
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 66
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then(@"I enter overview ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES ALL TRAINING TAKES PLAC", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.And("I click Save on Add provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Overview Special Chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_OverviewSpecialChars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Overview Special Chars", null, new string[] {
                        "CI"});
#line 73
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 74
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.Then("I enter overview 1234567890-= !\"£$%^&*()_+{}:\'#;@~/.,?> < ABCDEFGHIJKLMNOPQRSTUVW" +
                    "XYZ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
 testRunner.And("I click Save on Add provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Overview Over Max Chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_OverviewOverMaxChars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Overview Over Max Chars", null, new string[] {
                        "CI"});
#line 81
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 82
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then(@"I enter overview ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES PLACE IN THE WORK PLACE. WE WORK WITH OVER 3501 EMPLOYERS ACROSS WHOLE OF ENGLAND ALL TRAINING TAKES ALL TRAINING TAKES PLACE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.And("I click Save on Add provider details page leading to error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-496 Add Provider Details - Overview Non ASCII")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_496AddProviderDetails_OverviewNonASCII()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-496 Add Provider Details - Overview Non ASCII", null, new string[] {
                        "CI"});
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 90
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.When("i click add alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.Then("I enter overview 我想输入文字", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.And("I click Save on Add provider details page leading to error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-497 Edit Provider Details - Alias")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_497EditProviderDetails_Alias()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-497 Edit Provider Details - Alias", null, new string[] {
                        "CI"});
#line 97
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 98
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.When("i click edit alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.Then("I edit alias Test Alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.And("I click Save on Edit provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-497 Edit Provider Details - Overview")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_497EditProviderDetails_Overview()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-497 Edit Provider Details - Overview", null, new string[] {
                        "CI"});
#line 105
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 106
 testRunner.When("I click on the Provider name in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.Then("I am taken to the provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.When("i click edit alias", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 109
 testRunner.Then("I edit overview Provider Overview Testing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.And("I click Save on Edit provider details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

