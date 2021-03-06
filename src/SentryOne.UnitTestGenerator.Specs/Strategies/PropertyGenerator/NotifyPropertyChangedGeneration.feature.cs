// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SentryOne.UnitTestGenerator.Specs.Strategies.PropertyGenerator
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NotifyPropertyChangedGeneration")]
    public partial class NotifyPropertyChangedGenerationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NotifyPropertyChangedGeneration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NotifyPropertyChangedGeneration", "\tI am checking the Notify Property Changed Generation strategy", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Notify Property Changed Generation")]
        public virtual void NotifyPropertyChangedGeneration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Notify Property Changed Generation", null, ((string[])(null)));
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 6
 testRunner.Given("I have a class defined as", "using System.ComponentModel;\r\nusing System.Windows.Media;\r\n\r\nnamespace AssemblyCo" +
                    "re\r\n{\r\n   public class PropertyChange : INotifyPropertyChanged\r\n   {\r\n       pri" +
                    "vate string name;\r\n\r\n       public string Name\r\n       {\r\n           get { retur" +
                    "n name; }\r\n           set\r\n           {\r\n               name = value;\r\n         " +
                    "      OnPropertChanged(\"Name\");\r\n               OnPropertChanged(\"FullName\");\r\n " +
                    "          }\r\n       }\r\n\r\n       private string lastname;\r\n\r\n       public string" +
                    " LastName\r\n       {\r\n           get { return lastname; }\r\n           set\r\n      " +
                    "     {\r\n               lastname = value;\r\n               OnPropertChanged(\"LastN" +
                    "ame\");\r\n               OnPropertChanged(\"FullName\");\r\n           }\r\n       }\r\n\r\n" +
                    "       private string fullName;\r\n\r\n       public string FullName\r\n       {\r\n    " +
                    "       get { return fullName; }\r\n           set\r\n           {\r\n               fu" +
                    "llName = value;\r\n               OnPropertChanged(\"FullName\");\r\n           }\r\n   " +
                    "    }\r\n\r\n       private Color color;\r\n\r\n       public Color Color\r\n       {\r\n   " +
                    "        get { return color; }\r\n           set\r\n           {\r\n               colo" +
                    "r = value;\r\n               OnPropertChanged(\"Color\");\r\n           }\r\n       }\r\n\r" +
                    "\n\tpublic string notChange { get}\r\n\r\n       public PropertyChange()\r\n       {\r\n\r\n" +
                    "       }\r\n\r\n       public event PropertyChangedEventHandler PropertyChanged;\r\n\r\n" +
                    "       private void OnPropertChanged(string propertyName)\r\n       {\r\n           " +
                    "if (PropertyChanged != null)\r\n               PropertyChanged(this, new PropertyC" +
                    "hangedEventArgs(propertyName));\r\n       }\r\n   }\r\n}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
 testRunner.And("I set my test framework to \'NUnit3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("I set my mock framework to \'FakeItEasy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.When("I generate tests for the property using the strategy \'NotifyPropertyChangedGenera" +
                    "tionStrategy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("I expect a method called \'CanSetAndGetName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
  testRunner.And("I expect it to contain the statement \'_testClass.CheckProperty(x => x.Name);\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("I expect a method called \'CanSetAndGetLastName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
  testRunner.And("I expect it to have the attribute \'Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("I expect a method called \'CanSetAndGetFullName\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("I expect a method called \'CanSetAndGetColor\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
  testRunner.And("I expect it to contain the statement \'_testClass.CheckProperty(x => x.Color, defa" +
                    "ult(Color), default(Color));\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("I expect no method with a name like \'.*notChange.*\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
