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
          
            Pages = new PagesCollection(capabilities, baseUrl,hubUrl);
            Auth = new AuthModul(Pages);
            Navigator = new NavigationModul(this);
        }

       
        public AuthModul Auth { get; set; }
       
        public NavigationModul Navigator { get; set; }

        private PagesCollection Pages { get; set; }
    }
}