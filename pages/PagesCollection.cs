using System.Text;
using System;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class PagesCollection
    {
        public IWebDriver driver;
        internal string baseUrl;
        public PagesCollection(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            driver = WebDriverFactory.GetDriver(hubUrl, capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            //не явное ожидание тут пока
            if (!driver.Url.StartsWith(baseUrl))
            {
                driver.Navigate().GoToUrl(baseUrl);
            }
            this.baseUrl = baseUrl;


            Login = InitElements(new LoginPage(this));
            Internal = InitElements(new InternalPage(this));
            Lending = InitElements(new LendingPage(this));
            UserProfile = InitElements(new UserProfilePage(this));
        }

        private T InitElements<T>(T page) where T : AnyPage
        {
            PageFactory.InitElements(driver, page);
            return page;
        }

        public InternalPage Internal { get; set; }

        public LendingPage Lending { get; set; }

        public LoginPage Login { get; set; }

        public UserProfilePage UserProfile { get; set; }
    }
}