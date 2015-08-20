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

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/div[2]/div/section/form/div[2]/div[1]/input")]
        public IWebElement PassInputOneReg;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/div[2]/div/section/form/div[3]/div/input")]
        public IWebElement PassInputTwoReg;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/div[2]/div/section/form/div[4]/button")]
        public IWebElement BtnRegOver;

    }
}
