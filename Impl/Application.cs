using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class Application
    {
       
        public Application(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
          
            Pages = new PagesCollection(capabilities, baseUrl, hubUrl);
            Auth = new AuthModul(Pages);
            Navigator = new NavigationModul(this);
            ActionOnDash = new ActionOnDashBoard(Pages);
            ActionOnPay = new ActionOnPayments(Pages);
            ActionOnDocs = new ActionOnDocuments(Pages);
        }

        

        public AuthModul Auth { get; set; }
       
        public NavigationModul Navigator { get; set; }

        private PagesCollection Pages { get; set; }

        public ActionOnDashBoard ActionOnDash { get; set; }
        public ActionOnPayments ActionOnPay { get; set; }

        public ActionOnDocuments ActionOnDocs { get; set; }
    }
}