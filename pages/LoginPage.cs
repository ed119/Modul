
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tooktodo
{
    public class LoginPage : AnyPage
    {
        public LoginPage(PagesCollection pageManager)
            : base(pageManager)
        {
        }
        //таб регистрация
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[1]/div[2]")] 
        public IWebElement TabRegistration;

        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div[1]/div[1]/input")] 
        public IWebElement NameField;

        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div[1]/div[2]/input")]
        public IWebElement LastNameField;

        //страница мыла
        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div[2]/div/div/input")] 
        public IWebElement EmailField;

        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div[3]/div/div/input")]   
         public IWebElement PasswordField;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div[4]/div/input")]
        public IWebElement SubmitButton;

        //таб авторизация
        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div[1]/div/input")] 
        public IWebElement EmailSigninElement;

        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div[2]/div/div/input")] 
        public IWebElement PassSigninElement;

        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div[4]/div[1]/input")] 
        public IWebElement SinginButtonElement;

        

        
        
        public bool IsOnThisPage()

            //проверка поля телефон, когда находишься на странице авторизации
        {
            return IsElementPresent(By.XPath("html/body/div[1]/div[2]/div/div/div/div[2]/div/div/div[2]/div[1]/form/div[1]/div[1]/input"));
        }

        //public bool IsOnThisPageAlert()
        //{
        //    return IsElementPresent(By.CssSelector(".reg-step__valid"));
        //    //проверка по появившейся валидахе
        //}
        
    }
}