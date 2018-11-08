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
namespace ApiTesting.ApiTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LARS")]
    public partial class LARSFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LARS.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LARS", "\t\tAs a Course Directory Micoservice function\r\n\t\tI want to Access the LARS resourc" +
                    "e\r\n\t\tSo that I retrieve LARS data for my searches", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with No Facet")]
        [NUnit.Framework.TestCaseAttribute("biology", null)]
        [NUnit.Framework.TestCaseAttribute("hair and beauty", null)]
        [NUnit.Framework.TestCaseAttribute("english", null)]
        [NUnit.Framework.TestCaseAttribute("beuaty", null)]
        [NUnit.Framework.TestCaseAttribute("hair", null)]
        [NUnit.Framework.TestCaseAttribute("plumming", null)]
        [NUnit.Framework.TestCaseAttribute("engineering", null)]
        [NUnit.Framework.TestCaseAttribute("", null)]
        [NUnit.Framework.TestCaseAttribute("in", null)]
        [NUnit.Framework.TestCaseAttribute("(QCF)", null)]
        public virtual void SendingALARSPostWithNoFacet(string search, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with No Facet", null, exampleTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.When(string.Format("user sends LARS request with no facets {0}", search), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with No Facet Special Chars")]
        [NUnit.Framework.TestCaseAttribute("&", null)]
        [NUnit.Framework.TestCaseAttribute("-", null)]
        [NUnit.Framework.TestCaseAttribute("(", null)]
        [NUnit.Framework.TestCaseAttribute(")", null)]
        [NUnit.Framework.TestCaseAttribute("\'", null)]
        [NUnit.Framework.TestCaseAttribute("@", null)]
        [NUnit.Framework.TestCaseAttribute("+", null)]
        [NUnit.Framework.TestCaseAttribute("=", null)]
        [NUnit.Framework.TestCaseAttribute(":", null)]
        [NUnit.Framework.TestCaseAttribute(",", null)]
        public virtual void SendingALARSPostWithNoFacetSpecialChars(string search, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with No Facet Special Chars", null, exampleTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
  testRunner.When(string.Format("user sends LARS request with no facets {0}", search), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
  testRunner.Then("Response should contains zero records", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with Facets")]
        [NUnit.Framework.TestCaseAttribute("biology", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'3\'", "AwardOrgCode eq \'EDEXCEL\'", null)]
        [NUnit.Framework.TestCaseAttribute("biology", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'4\'", "AwardOrgCode eq \'EDEXCEL\'", null)]
        [NUnit.Framework.TestCaseAttribute("biology", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'2\'", "AwardOrgCode eq \'IB\'", null)]
        [NUnit.Framework.TestCaseAttribute("biology", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'3\'", "AwardOrgCode eq \'IB\'", null)]
        [NUnit.Framework.TestCaseAttribute("biology", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'2\'", "AwardOrgCode eq \'AQA\'", null)]
        [NUnit.Framework.TestCaseAttribute("biology", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'2\'", "AwardOrgCode eq \'aqa\'", null)]
        [NUnit.Framework.TestCaseAttribute("biology", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'3\'", "AwardOrgCode eq \'AQA\'", null)]
        [NUnit.Framework.TestCaseAttribute("biology", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'4\'", "AwardOrgCode eq \'AQA\'", null)]
        [NUnit.Framework.TestCaseAttribute("ENGLISH", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'7\'", "AwardOrgCode eq \'UOT\'", null)]
        [NUnit.Framework.TestCaseAttribute("DENTAL", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'5\'", "AwardOrgCode eq \'OU\'", null)]
        [NUnit.Framework.TestCaseAttribute("dental", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'6\'", "AwardOrgCode eq \'OU\'", null)]
        [NUnit.Framework.TestCaseAttribute("medicine", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'X\'", "AwardOrgCode eq \'NONE\'", null)]
        [NUnit.Framework.TestCaseAttribute("APPRENTICE", "true", "NotionalNVQLevelv2", "AwardOrgCode", "NotionalNVQLevelv2 eq \'1\'", "AwardOrgCode eq \'WBA\'", null)]
        public virtual void SendingALARSPostWithFacets(string search, string count, string facet1, string facet2, string filter1, string filter2, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with Facets", null, exampleTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 43
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
  testRunner.When(string.Format("user sends LARS request with facets {0}, {1}, {2}, {3}, {4}, {5}", search, count, facet1, facet2, filter1, filter2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with One Facet no search term")]
        public virtual void SendingALARSPostWithOneFacetNoSearchTerm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with One Facet no search term", null, ((string[])(null)));
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 64
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "search",
                        "count",
                        "facets",
                        "filter"});
            table1.AddRow(new string[] {
                        "",
                        "true",
                        "NotionalNVQLevelv2",
                        "NotionalNVQLevelv2 eq \'2\'"});
#line 65
  testRunner.When("user sends LARS request with one facet:", ((string)(null)), table1, "When ");
#line 68
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with One Facet level 2")]
        public virtual void SendingALARSPostWithOneFacetLevel2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with One Facet level 2", null, ((string[])(null)));
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 72
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "search",
                        "count",
                        "facets",
                        "filter"});
            table2.AddRow(new string[] {
                        "biology",
                        "true",
                        "NotionalNVQLevelv2",
                        "NotionalNVQLevelv2 eq \'2\'"});
#line 73
  testRunner.When("user sends LARS request with one facet:", ((string)(null)), table2, "When ");
#line 76
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with One Facet level 3")]
        public virtual void SendingALARSPostWithOneFacetLevel3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with One Facet level 3", null, ((string[])(null)));
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 80
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "search",
                        "count",
                        "facets",
                        "filter"});
            table3.AddRow(new string[] {
                        "biology",
                        "true",
                        "NotionalNVQLevelv2",
                        "NotionalNVQLevelv2 eq \'3\'"});
#line 81
  testRunner.When("user sends LARS request with one facet:", ((string)(null)), table3, "When ");
#line 84
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with One Facet OrgCode")]
        public virtual void SendingALARSPostWithOneFacetOrgCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with One Facet OrgCode", null, ((string[])(null)));
#line 87
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 88
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "search",
                        "count",
                        "facets",
                        "filter"});
            table4.AddRow(new string[] {
                        "biology",
                        "true",
                        "AwardOrgCode",
                        "AwardOrgCode eq \'EDEXCEL\'"});
#line 89
  testRunner.When("user sends LARS request with one facet:", ((string)(null)), table4, "When ");
#line 92
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with One Facet Hair and Beauty")]
        public virtual void SendingALARSPostWithOneFacetHairAndBeauty()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with One Facet Hair and Beauty", null, ((string[])(null)));
#line 95
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 96
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "search",
                        "count",
                        "facets",
                        "filter"});
            table5.AddRow(new string[] {
                        "geography",
                        "true",
                        "NotionalNVQLevelv2",
                        "NotionalNVQLevelv2 eq \'4\'"});
#line 97
  testRunner.When("user sends LARS request with one facet:", ((string)(null)), table5, "When ");
#line 100
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with One Facet Hair and Beauty level 3")]
        public virtual void SendingALARSPostWithOneFacetHairAndBeautyLevel3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with One Facet Hair and Beauty level 3", null, ((string[])(null)));
#line 103
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 104
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "search",
                        "count",
                        "facets",
                        "filter"});
            table6.AddRow(new string[] {
                        "english",
                        "true",
                        "NotionalNVQLevelv2",
                        "NotionalNVQLevelv2 eq \'3\'"});
#line 105
  testRunner.When("user sends LARS request with one facet:", ((string)(null)), table6, "When ");
#line 108
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with Two Facets")]
        public virtual void SendingALARSPostWithTwoFacets()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with Two Facets", null, ((string[])(null)));
#line 111
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 112
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "search",
                        "count",
                        "facet1",
                        "facet2",
                        "filter1",
                        "filter2"});
            table7.AddRow(new string[] {
                        "biology",
                        "true",
                        "NotionalNVQLevelv2",
                        "AwardOrgCode",
                        "NotionalNVQLevelv2 eq \'4\'",
                        "AwardOrgCode eq \'EDEXCEL\'"});
#line 113
  testRunner.When("user sends LARS request with two facets:", ((string)(null)), table7, "When ");
#line 116
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sending a LARS post with Two Facets no search term")]
        public virtual void SendingALARSPostWithTwoFacetsNoSearchTerm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sending a LARS post with Two Facets no search term", null, ((string[])(null)));
#line 119
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 120
  testRunner.Given("a user is using the LARS resource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "search",
                        "count",
                        "facet1",
                        "facet2",
                        "filter1",
                        "filter2"});
            table8.AddRow(new string[] {
                        "",
                        "true",
                        "NotionalNVQLevelv2",
                        "AwardOrgCode",
                        "NotionalNVQLevelv2 eq \'4\'",
                        "AwardOrgCode eq \'EDEXCEL\'"});
#line 121
  testRunner.When("user sends LARS request with two facets:", ((string)(null)), table8, "When ");
#line 124
  testRunner.Then("Response should contain the correct information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
