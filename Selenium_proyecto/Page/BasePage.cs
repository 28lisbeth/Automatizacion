using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Selenium_proyecto.Page
{
    class BasePage
    {
        public RemoteWebDriver webDriver;
        public String baseURL;

        #region  DEFINIR NAVEGADOR
        public BasePage()
        {
            webDriver = (RemoteWebDriver)ScenarioContext.Current["webDriver"];
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void navegarUrlBase( String Url) 
        {
            webDriver.Navigate().GoToUrl(Url);
            baseURL = Url;
        }
        #endregion


        #region METODOS BASE
        public void sendText(By locator, string text)
        {
            webDriver.FindElement(locator).SendKeys(text);
        }
        public void doClic(By locator)
        {
            webDriver.FindElement(locator).Click();
        }
        #endregion

    }
}
