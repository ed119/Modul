using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class RegDataCompany : AnyPage
    {
        public RegDataCompany(PagesCollection pageManager)
            : base(pageManager)
        { }

        [FindsBy(How = How.CssSelector, Using = "#setogrnlater")]
        public IWebElement RefSetOgrnLater;


        [FindsBy(How = How.Id, Using = "reg-base:company:ogrn-input")]
        public IWebElement OgrnInputReg;

        [FindsBy(How = How.Id, Using = "findcompany")]
        public IWebElement BtnFindConpanyReg;

        [FindsBy(How = How.Id, Using = "reg-base:company:confirm")]
        public IWebElement BtnItsMyCo;
        

      
        



    }
}
