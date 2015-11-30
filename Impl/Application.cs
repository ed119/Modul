using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tooktodo
{
    public class Application
    {
        private IWebDriver driver;

        public Application(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            driver = driver;

            Pages = new PagesCollection(capabilities, baseUrl, hubUrl);
            Auth = new AuthModul(Pages);
            //Navigator = new NavigationModul(this);
            Dash = new ActionOnDash(Pages);
           
        }

        

        public AuthModul Auth { get; set; }
       
        //public NavigationModul Navigator { get; set; }

        private PagesCollection Pages { get; set; }
        public ActionOnDash Dash { get; set; }

      
    }
}