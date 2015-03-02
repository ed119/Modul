using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class InternalPage : AnyPage
    {
        public InternalPage(PageManager pageManager)
            : base(pageManager)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "a.b-leftmenu__exit")]
        public IWebElement LogoutLink;

        public bool IsOnThisPage()
        {
            return IsElementPresent(By.CssSelector("a.b-leftmenu__exit"));
        }
    }

}