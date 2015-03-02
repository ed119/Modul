using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class ApplicationManager
    {
        
        public ApplicationManager(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
          
            Pages = new PageManager(capabilities, baseUrl,hubUrl);
            Auth = new LoginHelper(this);
            Navigator = new NavigationHelper(this);
        }

       
        public LoginHelper Auth { get; set; }
        //{
        //    get
        //    {
        //        if (auth == null)
        //            auth = new LoginHelper(this.Pages);
        //        return auth;
        //    }
        //}

        public NavigationHelper Navigator { get; set; }

        public PageManager Pages { get; set; }
    }
}