using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class RegName : AnyPage
    {

        public RegName(PagesCollection pageManager)
            : base(pageManager)
        { }
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[1]/form/div[1]/div[1]/input")]
        public IWebElement SurNameReg;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[1]/form/div[1]/div[2]/input")]
        public IWebElement NameReg;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[1]/form/div[3]/div[1]/input")]
        public IWebElement PhoneReg;

        [FindsBy(How = How.Id, Using = "reg-base:contact:mail")]
        public IWebElement MailReg;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[1]/form/div[3]/div[2]/div[1]/a")]
        public IWebElement SelectCityReg;

        [FindsBy(How = How.CssSelector, Using = "#select2-result-label-3")]
        public IWebElement CityMoskow;
        

        [FindsBy(How = How.Id, Using = "reg-base:contact:next")]
        public IWebElement BtnNextReg;


        [FindsBy(How = How.Id, Using = "reg-base:contact:sms-input")]
        public IWebElement SmsInputReg;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[1]/form/div[6]/div/div/div/button")]
        public IWebElement BtnSmsNext;
    
    
    
    
    }
}
