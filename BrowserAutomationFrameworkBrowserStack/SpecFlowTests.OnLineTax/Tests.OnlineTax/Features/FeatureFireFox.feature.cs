﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("FeatureFireFox", Description="OnLineTaxLoginDeskTop\r\nOLTLoginDTop", SourceFile="Features\\FeatureFireFox.feature", SourceLine=0)]
    public partial class FeatureFireFoxFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FeatureFireFox.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FeatureFireFox", "OnLineTaxLoginDeskTop\r\nOLTLoginDTop", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void TS38FF(string mybrowser, string username, string password, string mytitle, string mytitle2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC623"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS38FF", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("BrowserName {0}", mybrowser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("Navigate to the OnLineTax  Homepage with title {0}", mytitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When(string.Format("Login with {0}  Password  {1}  page tile  {2}", username, password, mytitle2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("Logout   {0}", mytitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TS38FF, \"FF290os70r11\"", new string[] {
                "TC623"}, SourceLine=13)]
        public virtual void TS38FF_FF290Os70R11()
        {
            this.TS38FF("\"FF290os70r11\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TS38FF, \"FF300os80r08\"", new string[] {
                "TC623"}, SourceLine=14)]
        public virtual void TS38FF_FF300Os80R08()
        {
            this.TS38FF("\"FF300os80r08\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TS38FF, \"FF310os80r08\"", new string[] {
                "TC623"}, SourceLine=15)]
        public virtual void TS38FF_FF310Os80R08()
        {
            this.TS38FF("\"FF310os80r08\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("TS38FF, \"FF310os81r01\"", new string[] {
                "TC623"}, SourceLine=16)]
        public virtual void TS38FF_FF310Os81R01()
        {
            this.TS38FF("\"FF310os81r01\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FeatureFireFox")]
    public partial class FeatureFireFoxFeature_NUnit
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FeatureFireFox.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FeatureFireFox", "OnLineTaxLoginDeskTop\r\nOLTLoginDTop", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("TS38FF")]
        [NUnit.Framework.CategoryAttribute("TC623")]
        [NUnit.Framework.TestCaseAttribute("\"FF290os70r11\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"FF300os80r08\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"FF310os80r08\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", null)]
        [NUnit.Framework.TestCaseAttribute("\"FF310os81r01\"", "\"ivan@my.com\"", "\"password1\"", "\"MYOB Account - Sign in\"", "\"MYOB Account - Authorisation\"", null)]
        public virtual void TS38FF(string mybrowser, string username, string password, string mytitle, string mytitle2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC623"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TS38FF", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("BrowserName {0}", mybrowser), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("Navigate to the OnLineTax  Homepage with title {0}", mytitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When(string.Format("Login with {0}  Password  {1}  page tile  {2}", username, password, mytitle2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("Logout   {0}", mytitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
