﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Create bookings", new string[] {
            "BookingTestsTag"}, SourceFile="Features\\BookingTests.feature", SourceLine=1)]
    public partial class CreateBookingsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "BookingTestsTag"};
        
#line 1 "BookingTests.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Create bookings", null, ProgrammingLanguage.CSharp, new string[] {
                        "BookingTestsTag"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Morning", SourceLine=3)]
        public virtual void Morning()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Morning", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table1.AddRow(new string[] {
                            "09:00",
                            "Wentao Su"});
#line 5
 testRunner.When("A new booking is made with below details:", ((string)(null)), table1, "When ");
#line hidden
#line 8
 testRunner.Then("the booking api returns http status code: 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 9
 testRunner.Then("the successful new booking count is: 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Before Closure", SourceLine=10)]
        public virtual void BeforeClosure()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Before Closure", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table2.AddRow(new string[] {
                            "16:01",
                            "Wentao Su"});
#line 12
 testRunner.When("A new booking is made with below details:", ((string)(null)), table2, "When ");
#line hidden
#line 15
 testRunner.Then("the booking api returns http status code: 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.Then("the successful new booking count is: 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("4 X same time slot", SourceLine=17)]
        public virtual void _4XSameTimeSlot()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4 X same time slot", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table3.AddRow(new string[] {
                            "10:00",
                            "Wentao Su"});
                table3.AddRow(new string[] {
                            "10:00",
                            "Wentao Su"});
                table3.AddRow(new string[] {
                            "10:00",
                            "Wentao Su"});
#line 19
 testRunner.Given("There\'re below bookings:", ((string)(null)), table3, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table4.AddRow(new string[] {
                            "10:00",
                            "Wentao Su"});
#line 24
 testRunner.When("A new booking is made with below details:", ((string)(null)), table4, "When ");
#line hidden
#line 27
 testRunner.Then("the booking api returns http status code: 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.Then("the successful new booking count is: 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Double Overlapping", SourceLine=29)]
        public virtual void DoubleOverlapping()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Double Overlapping", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table5.AddRow(new string[] {
                            "12:00",
                            "Wentao Su"});
                table5.AddRow(new string[] {
                            "11:30",
                            "Wentao Su"});
                table5.AddRow(new string[] {
                            "12:30",
                            "Wentao Su"});
#line 31
 testRunner.Given("There\'re below bookings:", ((string)(null)), table5, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table6.AddRow(new string[] {
                            "12:00",
                            "Wentao Su"});
#line 36
 testRunner.When("A new booking is made with below details:", ((string)(null)), table6, "When ");
#line hidden
#line 39
 testRunner.Then("the booking api returns http status code: 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.Then("the successful new booking count is: 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Negative - Invalid input, time as text", SourceLine=41)]
        public virtual void Negative_InvalidInputTimeAsText()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Negative - Invalid input, time as text", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table7.AddRow(new string[] {
                            "abc",
                            "Wentao Su"});
#line 43
 testRunner.When("A new booking is made with below details:", ((string)(null)), table7, "When ");
#line hidden
#line 46
 testRunner.Then("the booking api returns http status code: 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Negative - Invalid input, empty name", SourceLine=47)]
        public virtual void Negative_InvalidInputEmptyName()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Negative - Invalid input, empty name", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 48
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table8.AddRow(new string[] {
                            "12:00",
                            ""});
#line 49
 testRunner.When("A new booking is made with below details:", ((string)(null)), table8, "When ");
#line hidden
#line 52
 testRunner.Then("the booking api returns http status code: 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Negative - Out of business hour, early", SourceLine=53)]
        public virtual void Negative_OutOfBusinessHourEarly()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Negative - Out of business hour, early", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 54
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table9.AddRow(new string[] {
                            "08:00",
                            "Wentao Su"});
#line 55
 testRunner.When("A new booking is made with below details:", ((string)(null)), table9, "When ");
#line hidden
#line 58
 testRunner.Then("the booking api returns http status code: 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.Then("the successful new booking count is: 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Negative - Out of business hour, early partial", SourceLine=60)]
        public virtual void Negative_OutOfBusinessHourEarlyPartial()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Negative - Out of business hour, early partial", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 61
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table10.AddRow(new string[] {
                            "08:30",
                            "Wentao Su"});
#line 62
 testRunner.When("A new booking is made with below details:", ((string)(null)), table10, "When ");
#line hidden
#line 65
 testRunner.Then("the booking api returns http status code: 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.Then("the successful new booking count is: 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Negative - Out of business hour, late", SourceLine=67)]
        public virtual void Negative_OutOfBusinessHourLate()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Negative - Out of business hour, late", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 68
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table11.AddRow(new string[] {
                            "17:00",
                            "Wentao Su"});
#line 69
 testRunner.When("A new booking is made with below details:", ((string)(null)), table11, "When ");
#line hidden
#line 72
 testRunner.Then("the booking api returns http status code: 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.Then("the successful new booking count is: 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Negative - Out of business hour, late partial", SourceLine=74)]
        public virtual void Negative_OutOfBusinessHourLatePartial()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Negative - Out of business hour, late partial", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 75
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table12.AddRow(new string[] {
                            "16:30",
                            "Wentao Su"});
#line 76
 testRunner.When("A new booking is made with below details:", ((string)(null)), table12, "When ");
#line hidden
#line 79
 testRunner.Then("the booking api returns http status code: 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
 testRunner.Then("the successful new booking count is: 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Negative - 5 X Same time slot", SourceLine=81)]
        public virtual void Negative_5XSameTimeSlot()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Negative - 5 X Same time slot", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 82
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table13.AddRow(new string[] {
                            "13:00",
                            "Wentao Su"});
                table13.AddRow(new string[] {
                            "13:00",
                            "Wentao Su"});
                table13.AddRow(new string[] {
                            "13:00",
                            "Wentao Su"});
                table13.AddRow(new string[] {
                            "13:00",
                            "Wentao Su"});
#line 83
 testRunner.Given("There\'re below bookings:", ((string)(null)), table13, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table14.AddRow(new string[] {
                            "13:00",
                            "Wentao Su"});
#line 89
 testRunner.When("A new booking is made with below details:", ((string)(null)), table14, "When ");
#line hidden
#line 92
 testRunner.Then("the booking api returns http status code: 409", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 93
 testRunner.Then("the successful new booking count is: 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Composite tests", SourceLine=94)]
        public virtual void CompositeTests()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Composite tests", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 95
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table15.AddRow(new string[] {
                            "14:00",
                            "Wentao Su"});
                table15.AddRow(new string[] {
                            "14:15",
                            "Wentao Su"});
                table15.AddRow(new string[] {
                            "14:30",
                            "Wentao Su"});
                table15.AddRow(new string[] {
                            "14:45",
                            "Wentao Su"});
#line 96
 testRunner.Given("There\'re below bookings:", ((string)(null)), table15, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table16.AddRow(new string[] {
                            "14:00",
                            "Wentao Su"});
#line 102
 testRunner.When("A new booking is made with below details:", ((string)(null)), table16, "When ");
#line hidden
#line 105
 testRunner.Then("the booking api returns http status code: 409", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 106
 testRunner.Then("the successful new booking count is: 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table17.AddRow(new string[] {
                            "14:59",
                            "Wentao Su"});
#line 107
 testRunner.When("A new booking is made with below details:", ((string)(null)), table17, "When ");
#line hidden
#line 110
 testRunner.Then("the booking api returns http status code: 409", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 111
 testRunner.Then("the successful new booking count is: 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "BookingTime",
                            "Name"});
                table18.AddRow(new string[] {
                            "15:00",
                            "Wentao Su"});
#line 112
 testRunner.When("A new booking is made with below details:", ((string)(null)), table18, "When ");
#line hidden
#line 115
 testRunner.Then("the booking api returns http status code: 201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.Then("the successful new booking count is: 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
