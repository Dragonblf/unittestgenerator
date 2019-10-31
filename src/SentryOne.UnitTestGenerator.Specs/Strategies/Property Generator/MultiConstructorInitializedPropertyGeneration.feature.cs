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
    [NUnit.Framework.DescriptionAttribute("MultiConstructorInitializedPropertyGeneration")]
    public partial class MultiConstructorInitializedPropertyGenerationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MultiConstructorInitializedPropertyGeneration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MultiConstructorInitializedPropertyGeneration", "\tI am checking the Multi Constructor Initialized  Property Generation strategy", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Multi Constructor Initialized Property Generation")]
        public virtual void MultiConstructorInitializedPropertyGeneration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multi Constructor Initialized Property Generation", null, ((string[])(null)));
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 6
 testRunner.Given("I have a class defined as", @"namespace TestNamespace.SubNameSpace
{

   public interface ITest
   {
       int ThisIsAProperty {get;set;}
	string StringProp {get;set;}
   }

   public class TestClass
   {
       public TestClass(string stringProp, ITest iTest)
       {

       }

       public TestClass(string stringProp)
       {

       }

       public TestClass(int? nullableIntProp, ITest iTest)
       {

       }

       public TestClass(int thisIsAProperty, ITest iTest)
       {

       }

       public TestClass(int thisIsAProperty)
       {

       }

    public void ThisIsAMethod(string methodName, int methodValue)
    {
	    System.Console.WriteLine(""Testing this"");
    }

       public string WillReturnAString()
       {
           return ""Hello"";
       }

       private string _thisIsAString = string.Empty;
       public string ThisIsAWriteOnlyString { set { _thisIsAString = value; }}

       public int ThisIsAProperty { get;set;}

	public string StringProp { get;set;}

       public ITest GetITest { get; }

       public TestClass ThisClass {get;set;}
   }
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
 testRunner.And("I set my test framework to \'NUnit3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("I set my mock framework to \'FakeItEasy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.When("I generate tests for the property using the strategy \'MultiConstructorInitialized" +
                    "PropertyGenerationStrategy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("I expect a method called \'ThisIsAPropertyIsInitializedCorrectly\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
  testRunner.And("I expect it to contain the statement \'Assert.That(_testClass.ThisIsAProperty, Is." +
                    "EqualTo(_thisIsAProperty));\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("I expect a method called \'StringPropIsInitializedCorrectly\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("I expect no method with a name like \'.*nullableIntProp.*\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
