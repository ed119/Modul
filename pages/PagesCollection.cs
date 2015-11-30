using System.Text;
using System;
using System.Security.Policy;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace Tooktodo
{
    public class PagesCollection
    {

        public IWebDriver driver;
        internal string baseUrl;
        public PagesCollection(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            driver = WebDriverFactory.GetDriver(hubUrl, capabilities);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(25));
            //не явное ожидание тут пока
            
            if (!driver.Url.StartsWith(baseUrl))
            {
                driver.Navigate().GoToUrl(baseUrl);
                if (driver.Url != baseUrl)
                {
                    WebDriverFactory.DismissAll();

                }
                
            }
            this.baseUrl = baseUrl;
           
            


            Login = InitElements(new LoginPage(this));
            Mail = InitElements(new MailPage(this));
            Dash = InitElements(new DashboardPage(this));

        }

        private T InitElements<T>(T page) where T : AnyPage
        {
            PageFactory.InitElements(driver, page);
            return page;
        }

       

        public LoginPage Login { get; set; }

        public MailPage Mail { get; set; }

        public DashboardPage Dash { get; set; }


     
    }
}