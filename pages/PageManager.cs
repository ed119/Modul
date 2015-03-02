using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class PageManager
    {
        public IWebDriver driver;

        public PageManager(OpenQA.Selenium.IWebDriver Driver)
        {
            this.driver = Driver;
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