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
        private LoginHelper auth;

        public ApplicationManager(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            Driver = WebDriverFactory.GetDriver(hubUrl, capabilities);
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            //не явное ожидание тут пока
            if (!Driver.Url.StartsWith(baseUrl))
            {
                Driver.Navigate().GoToUrl(baseUrl);
            }
            BaseURL = baseUrl;

            
            Pages = new PageManager(Driver);
            Navigator = new NavigationHelper(this);
        }

        public IWebDriver Driver { get; set; }

        public string BaseURL { get; set; }

        public LoginHelper Auth
        {
            get
            {
                if (auth == null)
                    auth = new LoginHelper(this.Pages);
                return auth;
            }
        }

        public NavigationHelper Navigator { get; set; }

        public PageManager Pages { get; set; }
    }
}