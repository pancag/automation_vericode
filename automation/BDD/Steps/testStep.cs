using TechTalk.SpecFlow;
using Automation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation.BDD.Steps

  [Binding]
  Class TestStep
  {
    TestLocators locators = new TestLocators();
    BaseCommands commands = new BaseCommands();
    IWebdriver = driver;

    [Given(@"Estou na pagina esperada")]
    public void EstouNaPaginaEsperada()
    {
      commands.GoTo();
    }

    [When(@"Eu preencher os campos primeiros 4 campos")]
    public void PreenchoOsprimeirosCampos(string make, string model, string CMM, string kW){
      commands.SelectList(locators.makeList, make);
      commands.SelectList(locators.modelList, model);
      commands.SendKeys(locators.ccmTxt, CMM);
      commands.SendKeys(locators.kWTxt, kW);
    }

    [Then(@"O teste está concluído")]
    {
      Console.WriteLine("Good Job");
    }