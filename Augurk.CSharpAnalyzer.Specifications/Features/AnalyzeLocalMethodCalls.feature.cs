﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Augurk.CSharpAnalyzer.Specifications.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AnalyzeLocalMethodCallsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "AnalyzeLocalMethodCalls.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Analyze Local Method Calls", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Analyze Local Method Calls")))
            {
                global::Augurk.CSharpAnalyzer.Specifications.Features.AnalyzeLocalMethodCallsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("a local method is called within the entrypoint")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Analyze Local Method Calls")]
        public virtual void ALocalMethodIsCalledWithinTheEntrypoint()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("a local method is called within the entrypoint", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("\'Cucumis.Specifications\' contains feature files", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When("an analysis is run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Kind",
                        "Local",
                        "Expression/Signature"});
            table1.AddRow(new string[] {
                        "When",
                        "",
                        "a local method is called within the entrypoint"});
            table1.AddRow(new string[] {
                        "Public",
                        "true",
                        "Cucumis.Gherkin.OnWater(Cucumis.WaterEventArgs), Cucumis"});
            table1.AddRow(new string[] {
                        "Protected",
                        "true",
                        "Cucumis.Gherkin.Grow(), Cucumis"});
            table1.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Console.WriteLine(string), mscorlib"});
#line 7
 testRunner.Then("the resulting report contains \'When a local method is called within the entrypoin" +
                    "t\'", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("an explicit base method is called within the entrypoint")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Analyze Local Method Calls")]
        public virtual void AnExplicitBaseMethodIsCalledWithinTheEntrypoint()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("an explicit base method is called within the entrypoint", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("\'Cucumis.Specifications\' contains feature files", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("an analysis is run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Kind",
                        "Local",
                        "Level",
                        "Expression/Signature"});
            table2.AddRow(new string[] {
                        "When",
                        "",
                        "0",
                        "an explicit base method is called within the entrypoint"});
            table2.AddRow(new string[] {
                        "Public",
                        "true",
                        "1",
                        "Cucumis.PickyGherkin.OnWater(Cucumis.WaterEventArgs), Cucumis"});
            table2.AddRow(new string[] {
                        "Protected",
                        "true",
                        "2",
                        "Cucumis.Gherkin.Grow(), Cucumis"});
            table2.AddRow(new string[] {
                        "Public",
                        "",
                        "3",
                        "System.Console.WriteLine(string), mscorlib"});
            table2.AddRow(new string[] {
                        "Public",
                        "",
                        "2",
                        "System.Console.WriteLine(string), mscorlib"});
#line 18
 testRunner.Then("the resulting report contains \'When an explicit base method is called within the " +
                    "entrypoint\'", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("a local method is called within the entrypoint explicitly on this")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Analyze Local Method Calls")]
        public virtual void ALocalMethodIsCalledWithinTheEntrypointExplicitlyOnThis()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("a local method is called within the entrypoint explicitly on this", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("\'Cucumis.Specifications\' contains feature files", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.When("an analysis is run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Kind",
                        "Local",
                        "Expression/Signature"});
            table3.AddRow(new string[] {
                        "When",
                        "",
                        "a local method is called within the entrypoint explicitly on this"});
            table3.AddRow(new string[] {
                        "Public",
                        "true",
                        "Cucumis.Gherkin.OnPlant(Cucumis.PlantEventArgs), Cucumis"});
            table3.AddRow(new string[] {
                        "Private",
                        "true",
                        "Cucumis.Gherkin.SetInitialSize(string), Cucumis"});
            table3.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Console.WriteLine(string), mscorlib"});
#line 29
 testRunner.Then("the resulting report contains \'When a local method is called within the entrypoin" +
                    "t explicitly on this\'", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
