﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Pickles_Website_MsTest_Lab.Test
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class 結帳運費試算驗證Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "結帳運費試算驗證.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "結帳運費試算驗證", "\t提供計算使用者的購物車運費", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "結帳運費試算驗證")))
            {
                Pickles_Website_MsTest_Lab.Test.結帳運費試算驗證Feature.FeatureSetup(null);
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
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("VIP帳號，只有購買五本書籍")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "結帳運費試算驗證")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("結帳運費試算驗證")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("VIP")]
        public virtual void VIP帳號只有購買五本書籍()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("VIP帳號，只有購買五本書籍", new string[] {
                        "結帳運費試算驗證",
                        "VIP"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ProductType",
                        "ProductSize"});
            table1.AddRow(new string[] {
                        "C#",
                        "Book",
                        "Small"});
            table1.AddRow(new string[] {
                        "SQL Server",
                        "Book",
                        "Small"});
            table1.AddRow(new string[] {
                        "Node.js",
                        "Book",
                        "Small"});
            table1.AddRow(new string[] {
                        "Asp.Net MVC",
                        "Book",
                        "Small"});
            table1.AddRow(new string[] {
                        "JavaScript",
                        "Book",
                        "Small"});
#line 7
 testRunner.Given("購物車中有", ((string)(null)), table1, "Given ");
#line 14
 testRunner.And("使用者為 VipUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("計算運費", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("運費應為 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("VIP帳號，購買五本書籍和一台家電")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "結帳運費試算驗證")]
        public virtual void VIP帳號購買五本書籍和一台家電()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("VIP帳號，購買五本書籍和一台家電", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ProductType",
                        "ProductSize"});
            table2.AddRow(new string[] {
                        "C#",
                        "Book",
                        "Small"});
            table2.AddRow(new string[] {
                        "SQL Server",
                        "Book",
                        "Small"});
            table2.AddRow(new string[] {
                        "Node.js",
                        "Book",
                        "Small"});
            table2.AddRow(new string[] {
                        "Asp.Net MVC",
                        "Book",
                        "Small"});
            table2.AddRow(new string[] {
                        "JavaScript",
                        "Book",
                        "Small"});
            table2.AddRow(new string[] {
                        "TV",
                        "Electronic",
                        "Big"});
#line 19
 testRunner.Given("購物車中有", ((string)(null)), table2, "Given ");
#line 27
 testRunner.And("使用者為 VipUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When("計算運費", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("運費應為 300", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("VIP帳號，購買四本書籍")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "結帳運費試算驗證")]
        public virtual void VIP帳號購買四本書籍()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("VIP帳號，購買四本書籍", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ProductType",
                        "ProductSize"});
            table3.AddRow(new string[] {
                        "C#",
                        "Book",
                        "Small"});
            table3.AddRow(new string[] {
                        "SQL Server",
                        "Book",
                        "Small"});
            table3.AddRow(new string[] {
                        "Node.js",
                        "Book",
                        "Small"});
            table3.AddRow(new string[] {
                        "Asp.Net MVC",
                        "Book",
                        "Small"});
#line 32
 testRunner.Given("購物車中有", ((string)(null)), table3, "Given ");
#line 38
 testRunner.And("使用者為 VipUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("計算運費", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("運費應為 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("VIP帳號，購買一台筆記型電腦和一本書籍")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "結帳運費試算驗證")]
        public virtual void VIP帳號購買一台筆記型電腦和一本書籍()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("VIP帳號，購買一台筆記型電腦和一本書籍", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ProductType",
                        "ProductSize"});
            table4.AddRow(new string[] {
                        "NetBook",
                        "Laptop",
                        "Medium"});
            table4.AddRow(new string[] {
                        "C#",
                        "Book",
                        "Small"});
#line 43
 testRunner.Given("購物車中有", ((string)(null)), table4, "Given ");
#line 47
 testRunner.And("使用者為 VipUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.When("計算運費", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("運費應為 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("一般帳號，只有購買五本書籍")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "結帳運費試算驗證")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("一般帳號")]
        public virtual void 一般帳號只有購買五本書籍()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("一般帳號，只有購買五本書籍", new string[] {
                        "一般帳號"});
#line 52
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ProductType",
                        "ProductSize"});
            table5.AddRow(new string[] {
                        "C#",
                        "Book",
                        "Small"});
            table5.AddRow(new string[] {
                        "SQL Server",
                        "Book",
                        "Small"});
            table5.AddRow(new string[] {
                        "Node.js",
                        "Book",
                        "Small"});
            table5.AddRow(new string[] {
                        "Asp.Net MVC",
                        "Book",
                        "Small"});
            table5.AddRow(new string[] {
                        "JavaScript",
                        "Book",
                        "Small"});
#line 53
 testRunner.Given("購物車中有", ((string)(null)), table5, "Given ");
#line 60
 testRunner.And("使用者為 NormalUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.When("計算運費", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.Then("運費應為 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("一般帳號帳號，購買四本書籍")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "結帳運費試算驗證")]
        public virtual void 一般帳號帳號購買四本書籍()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("一般帳號帳號，購買四本書籍", ((string[])(null)));
#line 64
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ProductType",
                        "ProductSize"});
            table6.AddRow(new string[] {
                        "C#",
                        "Book",
                        "Small"});
            table6.AddRow(new string[] {
                        "SQL Server",
                        "Book",
                        "Small"});
            table6.AddRow(new string[] {
                        "Node.js",
                        "Book",
                        "Small"});
            table6.AddRow(new string[] {
                        "Asp.Net MVC",
                        "Book",
                        "Small"});
#line 65
 testRunner.Given("購物車中有", ((string)(null)), table6, "Given ");
#line 71
 testRunner.And("使用者為 NormalUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.When("計算運費", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
 testRunner.Then("運費應為 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("一般帳號帳號，購買五本書籍和一台家電")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "結帳運費試算驗證")]
        public virtual void 一般帳號帳號購買五本書籍和一台家電()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("一般帳號帳號，購買五本書籍和一台家電", ((string[])(null)));
#line 75
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ProductType",
                        "ProductSize"});
            table7.AddRow(new string[] {
                        "C#",
                        "Book",
                        "Small"});
            table7.AddRow(new string[] {
                        "SQL Server",
                        "Book",
                        "Small"});
            table7.AddRow(new string[] {
                        "Node.js",
                        "Book",
                        "Small"});
            table7.AddRow(new string[] {
                        "Asp.Net MVC",
                        "Book",
                        "Small"});
            table7.AddRow(new string[] {
                        "JavaScript",
                        "Book",
                        "Small"});
            table7.AddRow(new string[] {
                        "TV",
                        "Electronic",
                        "Big"});
#line 76
 testRunner.Given("購物車中有", ((string)(null)), table7, "Given ");
#line 84
 testRunner.And("使用者為 NormalUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.When("計算運費", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then("運費應為 300", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("一般帳號帳號，購買一台筆記型電腦和一本書籍")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "結帳運費試算驗證")]
        public virtual void 一般帳號帳號購買一台筆記型電腦和一本書籍()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("一般帳號帳號，購買一台筆記型電腦和一本書籍", ((string[])(null)));
#line 88
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ProductType",
                        "ProductSize"});
            table8.AddRow(new string[] {
                        "NetBook",
                        "Laptop",
                        "Medium"});
            table8.AddRow(new string[] {
                        "C#",
                        "Book",
                        "Small"});
#line 89
 testRunner.Given("購物車中有", ((string)(null)), table8, "Given ");
#line 93
 testRunner.And("使用者為 NormalUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("計算運費", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("運費應為 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("一般帳號帳號，購買一台筆記型電腦")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "結帳運費試算驗證")]
        public virtual void 一般帳號帳號購買一台筆記型電腦()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("一般帳號帳號，購買一台筆記型電腦", ((string[])(null)));
#line 97
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ProductType",
                        "ProductSize"});
            table9.AddRow(new string[] {
                        "NetBook",
                        "Laptop",
                        "Medium"});
#line 98
 testRunner.Given("購物車中有", ((string)(null)), table9, "Given ");
#line 101
 testRunner.And("使用者為 NormalUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.When("計算運費", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("運費應為 200", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
