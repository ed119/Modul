using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class ActionRegs : BaseModul
    {
        public ActionRegs(PagesCollection pages)
            : base(pages)
        { }
        public void GoToStartReg(AccountData account)
        //перешел на начало регистрации
        {
            pages.Login.Notyetreg.Click();
        }

        public void RegWithOutOgrn(AccountData account)
        {
            var random = new Random();
            var x = random.Next(1000000, 99999999).ToString("0000000000");
            var list = new List<string>();
            var email = x + "@mail.ru";

            pages.RegN.SurNameReg.Clear();
            pages.RegN.SurNameReg.SendKeys(account.SurName);
            pages.RegN.NameReg.Clear();
            pages.RegN.NameReg.SendKeys(account.Name);
            pages.RegN.PhoneReg.Clear();
            pages.RegN.PhoneReg.SendKeys(x);
            pages.RegN.MailReg.Clear();
            pages.RegN.MailReg.SendKeys(email);
            pages.RegN.SelectCityReg.Click();
            pages.RegN.CityMoskow.Click();
            pages.RegN.BtnNextReg.Click();
            pages.RegN.SmsInputReg.Clear();
            pages.RegN.SmsInputReg.SendKeys(account.smscode);
            pages.RegN.BtnSmsNext.Click();
            pages.RegDataCo.RefSetOgrnLater.Click();
            pages.RegP.PassInputOneReg.Clear();
            pages.RegP.PassInputOneReg.SendKeys(account.PassTwo);
            pages.RegP.PassInputTwoReg.Clear();
            pages.RegP.PassInputTwoReg.SendKeys(account.PassTwo);
            pages.RegP.BtnRegOver.Click();

        }

        public void RegWithO(AccountData account)
        {
            var random = new Random();
            var x = random.Next(1000000, 99999999).ToString("0000000000");
            var list = new List<string>();
            var email = x + "@mail.ru";
            
            pages.RegN.SurNameReg.Clear();
            pages.RegN.SurNameReg.SendKeys(account.SurName);
            pages.RegN.NameReg.Clear();
            pages.RegN.NameReg.SendKeys(account.Name);
            pages.RegN.PhoneReg.Clear();
            pages.RegN.PhoneReg.SendKeys(x);
            pages.RegN.MailReg.Clear();
            pages.RegN.MailReg.SendKeys(email);
            pages.RegN.SelectCityReg.Click();
            pages.RegN.CityMoskow.Click();
            pages.RegN.BtnNextReg.Click();
            pages.RegN.SmsInputReg.Clear();
            pages.RegN.SmsInputReg.SendKeys(account.smscode);
            System.Threading.Thread.Sleep(2000);

            pages.RegN.BtnSmsNext.Click();
            pages.RegDataCo.OgrnInputReg.Clear();
            pages.RegDataCo.OgrnInputReg.SendKeys(account.Ogrn);
            pages.RegDataCo.BtnFindConpanyReg.Click();
            System.Threading.Thread.Sleep(2000);
            pages.RegDataCo.BtnItsMyCo.Click();
            pages.RegP.PassInputOneReg.Clear();
            pages.RegP.PassInputOneReg.SendKeys(account.PassTwo);
            pages.RegP.PassInputTwoReg.Clear();
            pages.RegP.PassInputTwoReg.SendKeys(account.PassTwo);
            pages.RegP.BtnRegOver.Click();

        }



    }
}
