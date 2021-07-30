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
namespace BDD.Tests.Spec.Api
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ClienteCustomerFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CustomerAPI.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-br"), "Cliente (Customer)", "\tConsumir a API do Customer \r\n\tassim poderemos fazer as integrações necessárias n" +
                    "o sistema ", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Cliente (Customer)")))
            {
                BDD.Tests.Spec.Api.ClienteCustomerFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Listar todos os clientes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cliente (Customer)")]
        public virtual void ListarTodosOsClientes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Listar todos os clientes", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("que a url do endpoint é \'http://localhost:64861/api/customer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 9
 testRunner.And("o método http é \'GET\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.When("chamar o servico", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 11
 testRunner.Then("statuscode da resposta deverá ser \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "NomeCompleto",
                        "Endereco",
                        "DataNascimento",
                        "CPF",
                        "Email"});
            table1.AddRow(new string[] {
                        "Diego",
                        "Rua Teste de API",
                        "03/09/1981",
                        "000.000.000-00",
                        "rafaelcruz.net81@gmail.com"});
            table1.AddRow(new string[] {
                        "Diego 2",
                        "Rua Teste de API",
                        "03/09/1981",
                        "111.111.111-11",
                        "rafaelcruz.net81@gmail.com"});
            table1.AddRow(new string[] {
                        "Diego 3",
                        "Rua Teste de API",
                        "03/09/1981",
                        "222.222.222-22",
                        "rafaelcruz.net81@gmail.com"});
#line 12
 testRunner.And("uma resposta com a uma lista do tipo \'WebApplication.Models.CustomerModel\' deve s" +
                    "er retornada com os seguintes valores:", ((string)(null)), table1, "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Consultar um Cliente pelo seu Identificador")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cliente (Customer)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("criarCliente")]
        public virtual void ConsultarUmClientePeloSeuIdentificador()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Consultar um Cliente pelo seu Identificador", new string[] {
                        "criarCliente"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("que a url do endpoint é \'http://localhost:64861/api/customer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 21
 testRunner.And("informei o seguinte argumento de rota \'id\' de cenario", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 22
 testRunner.And("o método http é \'GET\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 23
 testRunner.When("chamar o servico", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 24
 testRunner.Then("statuscode da resposta deverá ser \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "NomeCompleto",
                        "Endereco",
                        "DataNascimento",
                        "CPF",
                        "Email",
                        "DataCadastro"});
            table2.AddRow(new string[] {
                        "<Inteiro>",
                        "Diego",
                        "Rua Teste de API",
                        "03/09/1981",
                        "000.000.000-00",
                        "rafaelcruz.net81@gmail.com",
                        "<Hoje>"});
#line 25
 testRunner.And("uma resposta do tipo \'WebApplication.Models.CustomerModel\' deve ser retornada com" +
                    " os seguintes valores:", ((string)(null)), table2, "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Criar um Cliente")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cliente (Customer)")]
        public virtual void CriarUmCliente()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar um Cliente", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("que a url do endpoint é \'http://localhost:64861/api/customer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 31
 testRunner.And("o método http é \'POST\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "NomeCompleto",
                        "Endereco",
                        "DataNascimento",
                        "CPF",
                        "Email"});
            table3.AddRow(new string[] {
                        "Diego",
                        "Rua Teste de API",
                        "03/09/1981",
                        "000.000.000-00",
                        "rafaelcruz.net81@gmail.com"});
#line 32
 testRunner.And("informei o seguinte argumento do tipo \'WebApplication.Models.CustomerModel\':", ((string)(null)), table3, "E ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Nome",
                        "Email",
                        "Password"});
            table4.AddRow(new string[] {
                        "Teste",
                        "teste@teste.com.br",
                        "123456A#"});
#line 35
 testRunner.And("a informei a propriedade \'Usuario\' do tipo \'WebApplication.Models.CustomerModel c" +
                    "om o valores\':", ((string)(null)), table4, "E ");
#line 38
 testRunner.When("chamar o servico", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 39
 testRunner.Then("statuscode da resposta deverá ser \'Created\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "NomeCompleto",
                        "Endereco",
                        "DataNascimento",
                        "CPF",
                        "Email",
                        "Id"});
            table5.AddRow(new string[] {
                        "Diego",
                        "Rua Teste de API",
                        "03/09/1981",
                        "000.000.000-00",
                        "rafaelcruz.net81@gmail.com",
                        "<Inteiro>"});
#line 40
 testRunner.And("uma resposta do tipo \'WebApplication.Models.CustomerModel\' deve ser retornada com" +
                    " os seguintes valores:", ((string)(null)), table5, "E ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
