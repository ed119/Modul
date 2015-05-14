using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class LendingPage : AnyPage
    {
        public LendingPage(PagesCollection pageManager)
            : base(pageManager)
        {
        }

        [FindsBy(How = How.LinkText, Using = "Личный кабинет")]
        public IWebElement LogoutLink;
         
        public bool IsOnThisPage()
        {
            return IsElementPresent(By.LinkText("Личный кабинет"));
        }
        
        
        
    }
}