﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitConverter.Spec
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Temperature")]
    public partial class TemperatureFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TemperatureConversion.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Temperature", "In order to use the converter appliction\r\nAs a WP7 user\r\nI want to switch to Temp" +
                    "erature, enter some numbers and see the results", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can change to Temperature")]
        public virtual void ICanChangeToTemperature()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can change to Temperature", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("my app is clean installed and running");
#line 8
 testRunner.Then("take a picture");
#line 9
 testRunner.And("I see the control \"textBlockCategory\" has value \"LENGTH\"");
#line 10
 testRunner.Then("I press the control \"btnConversions\"");
#line 11
 testRunner.Then("I wait 1 seconds");
#line 12
 testRunner.Then("take a picture");
#line 13
 testRunner.Then("I wait for the control \"pivot\" to appear");
#line 14
 testRunner.Then("I flick \"RightToLeft\"");
#line 15
 testRunner.Then("I wait 1 seconds");
#line 16
 testRunner.Then("I tap in the middle of the control \"From:Units_Temp_Kelvin\"");
#line 17
 testRunner.Then("I tap in the middle of the control \"To:Units_Temp_Fahrenheit\"");
#line 18
 testRunner.Then("take a picture");
#line 19
 testRunner.Then("I press the control \"buttonDone\"");
#line 20
 testRunner.Then("I wait 1 seconds");
#line 21
 testRunner.Then("take a picture");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "textBlockCategory",
                        "TEMP"});
            table1.AddRow(new string[] {
                        "textBlockInputValue",
                        "0"});
            table1.AddRow(new string[] {
                        "textBlockResultValue",
                        "-459.67"});
            table1.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Kelvin"});
            table1.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Fahrenheit"});
#line 22
 testRunner.And("I see the values", ((string)(null)), table1);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Data is not cleared when changing to temperature")]
        public virtual void DataIsNotClearedWhenChangingToTemperature()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Data is not cleared when changing to temperature", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("my app is clean installed and running");
#line 32
 testRunner.Then("take a picture");
#line 33
 testRunner.And("I see the control \"textBlockCategory\" has value \"LENGTH\"");
#line 34
 testRunner.Then("I press the control \"btnKeypadKey2\"");
#line 35
 testRunner.And("I press the control \"btnKeypadKey4\"");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "textBlockCategory",
                        "LENGTH"});
            table2.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Inches"});
            table2.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Feet"});
            table2.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table2.AddRow(new string[] {
                        "textBlockResultValue",
                        "2"});
#line 36
 testRunner.And("I see the values", ((string)(null)), table2);
#line 43
 testRunner.Then("I press the control \"btnConversions\"");
#line 44
 testRunner.Then("I wait 1 seconds");
#line 45
 testRunner.Then("take a picture");
#line 46
 testRunner.Then("I wait for the control \"pivot\" to appear");
#line 47
 testRunner.Then("I flick \"RightToLeft\"");
#line 48
 testRunner.Then("I wait 1 seconds");
#line 49
 testRunner.Then("I tap in the middle of the control \"From:Units_Temp_Kelvin\"");
#line 50
 testRunner.Then("I tap in the middle of the control \"To:Units_Temp_Fahrenheit\"");
#line 51
 testRunner.Then("take a picture");
#line 52
 testRunner.Then("I press the control \"buttonDone\"");
#line 53
 testRunner.Then("I wait 1 seconds");
#line 54
 testRunner.Then("take a picture");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "textBlockCategory",
                        "TEMP"});
            table3.AddRow(new string[] {
                        "textBlockInputValue",
                        "24"});
            table3.AddRow(new string[] {
                        "textBlockResultValue",
                        "-416.47"});
            table3.AddRow(new string[] {
                        "textBlockInputUnit",
                        "Kelvin"});
            table3.AddRow(new string[] {
                        "textBlockResultUnit",
                        "Fahrenheit"});
#line 55
 testRunner.And("I see the values", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
