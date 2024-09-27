using TechTalk.SpecFlow;
using Automation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation.Base
{
  public abstract class BaseCommands
  {
    public static GoTo()
    {
      try
      {
        driver = new ChromeDriver();
        driver.Navigate.GoTo("https://sampleapp.tricentis.com/101/app.php");
      }
      catch (Exception e)
      {
        throw new Exception($"Erro ao abrir ChromeDriver.\n{e.Message}")
      }
    }

    public void SelectList(By by, string option)
    {
      try
      {
        var selectElement = driver.FindElement(locator.makeList)
        var selectList = new SelectElement(selectElement)
        selectList.SelectByValue("");
      }
      catch (Exception e)
      {
        throw new Exception($"Erro ao selecionar texto no elemento ({by.ToString()}).\n{e.Message}")
      }
    }
  }

  public void SendKeys(By by, string text)
  {
    try
    {
      driver.FindElement(by).sendKeys(text);
    }
    catch (Exception e)
      {
        throw new Exception($"Erro digitar texto ({by.ToString()}).\n{e.Message}")
      }
  }

  public void ClickButton(By by)
  {
    try
    {
      driver.FindElement(by).Click();
    }
    catch (Exception e)
      {
        throw new Exception($"Erro ao clicar no elemento ({by.ToString()}).\n{e.Message}")
      }
  }
}