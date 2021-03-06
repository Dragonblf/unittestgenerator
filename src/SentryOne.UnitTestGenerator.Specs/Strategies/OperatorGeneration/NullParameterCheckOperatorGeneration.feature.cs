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
namespace SentryOne.UnitTestGenerator.Specs.Strategies.OperatorGeneration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NullParameterCheckOperatorGeneration")]
    public partial class NullParameterCheckOperatorGenerationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NullParameterCheckOperatorGeneration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NullParameterCheckOperatorGeneration", "\tI am checking the Null Parameter Check Operator Generation strategy", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Null Parameter Check Operator Generation")]
        public virtual void NullParameterCheckOperatorGeneration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Null Parameter Check Operator Generation", null, ((string[])(null)));
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 6
 testRunner.Given("I have a class defined as", @"namespace TestNamespace.SubNameSpace
{
using System;

class Calculator { 
     
	public int number = 0; 
     
	// parameterized constructor 
	public Calculator(int n) 
	{ 
		number = n; 
	} 
     
	public static Calculator operator + (Calculator Calc1,  
										 Calculator Calc2) 
	{ 
		Calculator Calc3 = new Calculator(0); 
		Calc3.number = Calc2.number + Calc1.number; 
		return Calc3; 
	} 

	public static Calculator operator - (Calculator Calc1,  
										 Calculator Calc2) 
	{ 
		Calculator Calc3 = new Calculator(0); 
		Calc3.number = Calc2.number - Calc1.number; 
		return Calc3; 
	} 

	public static Calculator operator - (Calculator Calc1) 
	{ 
		Calculator Calc3 = new Calculator(0); 
		Calc3.number = Calc1.number * -1; 
		return Calc3; 
	} 

	public static Calculator operator * (Calculator Calc1,  
										 Calculator Calc2) 
	{ 
		Calculator Calc3 = new Calculator(0); 
		Calc3.number = Calc2.number * Calc1.number; 
		return Calc3; 
	} 

	public static Calculator operator / (Calculator Calc1,  
										 Calculator Calc2) 
	{ 
		Calculator Calc3 = new Calculator(0); 
		Calc3.number = Calc2.number / Calc1.number; 
		return Calc3; 
	} 

} 
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.And("I set my test framework to \'MS Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("I set my mock framework to \'Moq\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("I generate tests for the operator using the strategy \'NullParameterCheckOperatorG" +
                    "enerationStrategy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "methodName",
                        "methodStatement"});
            table2.AddRow(new string[] {
                        "CannotCallPlusOperatorWithNullCalc1",
                        "Assert.ThrowsException<ArgumentNullException>(() => { var result = default(Calcul" +
                            "ator) + new Calculator({{{AnyInteger}}});});"});
            table2.AddRow(new string[] {
                        "CannotCallPlusOperatorWithNullCalc2",
                        "Assert.ThrowsException<ArgumentNullException>(() => { var result = new Calculator" +
                            "({{{AnyInteger}}}) + default(Calculator);});"});
            table2.AddRow(new string[] {
                        "CannotCallMinusOperatorWithNullCalc1",
                        "Assert.ThrowsException<ArgumentNullException>(() => { var result = default(Calcul" +
                            "ator) - new Calculator({{{AnyInteger}}});});"});
            table2.AddRow(new string[] {
                        "CannotCallMinusOperatorWithNullCalc2",
                        "Assert.ThrowsException<ArgumentNullException>(() => { var result = new Calculator" +
                            "({{{AnyInteger}}}) - default(Calculator);});"});
            table2.AddRow(new string[] {
                        "CannotCallUnaryMinusOperatorWithNullCalc1",
                        "Assert.ThrowsException<ArgumentNullException>(() => { var result = -default(Calcu" +
                            "lator);});"});
            table2.AddRow(new string[] {
                        "CannotCallMultiplicationOperatorWithNullCalc1",
                        "Assert.ThrowsException<ArgumentNullException>(() => { var result = default(Calcul" +
                            "ator) * new Calculator({{{AnyInteger}}});});"});
            table2.AddRow(new string[] {
                        "CannotCallMultiplicationOperatorWithNullCalc2",
                        "Assert.ThrowsException<ArgumentNullException>(() => { var result = new Calculator" +
                            "({{{AnyInteger}}}) * default(Calculator);});"});
            table2.AddRow(new string[] {
                        "CannotCallDivisionOperatorWithNullCalc1",
                        "Assert.ThrowsException<ArgumentNullException>(() => { var result = default(Calcul" +
                            "ator) / new Calculator({{{AnyInteger}}});});"});
            table2.AddRow(new string[] {
                        "CannotCallDivisionOperatorWithNullCalc2",
                        "Assert.ThrowsException<ArgumentNullException>(() => { var result = new Calculator" +
                            "({{{AnyInteger}}}) / default(Calculator);});"});
#line 67
 testRunner.Then("I expect methods with statements like:", ((string)(null)), table2, "Then ");
#line 78
 testRunner.And("I expect no method with a name like \'.*UnaryMinusOperatorWithNullCalc2.*\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
