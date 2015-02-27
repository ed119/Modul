using System;
using OpenQA.Selenium;

namespace Modul
{
    public class ApplicationManager
    {
        public ApplicationManager(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            Driver = WebDriverFactory.GetDriver(hubUrl, capabilities);
            if (!Driver.Url.StartsWith(baseUrl))
            {
                Driver.Navigate().GoToUrl(baseUrl);
            }
            BaseURL = baseUrl;

            Auth = new LoginHelper(this);
            Navigator = new NavigationHelper(this);
        }

        public IWebDriver Driver { get; set; }

        public string BaseURL { get; set; }

        public LoginHelper Auth { get; set; }

        public NavigationHelper Navigator { get; set; }
    }
}