using OpenQA.Selenium;

using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Net_Dem0.Alert
{
   public  class AlertClass
    {
        
        public AlertClass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
  
        //To locate the webelement for the JSALERT 
        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsAlert()']")]
        [CacheLookup]
        public IWebElement jsAlert;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
        //To Locate the Webelement for the Confirm alert - OK
        [FindsBy(How = How.CssSelector, Using = "button[onclick = 'jsConfirm()']")]
        [CacheLookup]
        public IWebElement jsConfirm;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickonResult;

        //To Locate the webelement for the Confirm - Dismiss
        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsConfirm()'")]
        [CacheLookup]
        public IWebElement jsDismiss;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickforResult;

        //To Locate the webelement for the Send-Text
        [FindsBy(How = How.CssSelector, Using = "button[onclick = 'jsPrompt()']")]
        [CacheLookup]
        public IWebElement jsPrompt;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clicktheResult;

    }
}
