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
        [FindsBy(How = How.Id, Using = "reg-base:contact:surname")]
        public IWebElement SurNameReg;

        [FindsBy(How = How.Id, Using = "reg-base:contact:name")]
        public IWebElement NameReg;

        [FindsBy(How = How.Id, Using = "reg-base:contact:phone")]
        public IWebElement PhoneReg;

        [FindsBy(How = How.Id, Using = "reg-base:contact:mail")]
        public IWebElement MailReg;

        [FindsBy(How = How.Id, Using = "s2id_reg-base:contact:city")]
        public IWebElement SelectCityReg;

        [FindsBy(How = How.CssSelector, Using = "#select2-result-label-3")]
        public IWebElement CityMoskow;
        

        [FindsBy(How = How.Id, Using = "reg-base:contact:next")]
        public IWebElement BtnNextReg;


        [FindsBy(How = How.Id, Using = "reg-base:contact:sms-input")]
        public IWebElement SmsInputReg;

        [FindsBy(How = How.Id, Using = "reg-base:contact:sms-next")]
        public IWebElement BtnSmsNext;
    
    
    
    
    }
}
