﻿using System.Text;
using System;
using System.Security.Policy;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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
            DashBoard = InitElements(new DashBoardPage(this));
            Lending = InitElements(new LendingPage(this));
            UserProfile = InitElements(new UserProfilePage(this));
            SpecialLogin = InitElements(new SupportLoginPage(this));
            Payments = InitElements(new PaymentsPage(this));
            Documents = InitElements(new DocumentsPage(this));
            RegN = InitElements(new RegName(this));
            RegP = InitElements(new RegPass(this));
            RegDataCo = InitElements(new RegDataCompany(this));
        }

        private T InitElements<T>(T page) where T : AnyPage
        {
            PageFactory.InitElements(driver, page);
            return page;
        }

        public PaymentsPage Payments { get; set; }

        public DashBoardPage DashBoard { get; set; }

        public LendingPage Lending { get; set; }

        public LoginPage Login { get; set; }

        public UserProfilePage UserProfile { get; set; }

        public SupportLoginPage SpecialLogin { get; set; }

        public DocumentsPage Documents { get; set; }

        public RegName RegN { get; set; }

        public RegPass RegP { get; set; }

        public RegDataCompany RegDataCo { get; set; }
    }
}