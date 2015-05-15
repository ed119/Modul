using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class RegPass : AnyPage
    {
        public RegPass(PagesCollection pageManager)
            : base(pageManager)
        { }

        [FindsBy(How = How.Id, Using = "reg-base:password:pass-one-input")]
        public IWebElement PassInputOneReg;

        [FindsBy(How = How.Id, Using = "reg-base:password:pass-two-input")]
        public IWebElement PassInputTwoReg;

        [FindsBy(How = How.Id, Using = "reg-base:password:enter")]
        public IWebElement BtnRegOver;

    }
}
