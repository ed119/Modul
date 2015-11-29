using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        [FindsBy(How = How.Name, Using = "phone")]
        public IWebElement PhoneField;
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordField;
        [FindsBy(How = How.XPath, Using = @"//form[@name='form']/div[4]/button[1]")]
        public IWebElement GiveMeCode;
        [FindsBy(How = How.XPath, Using = "//div[@class='sms-bl__inner']/div/input")]
        public IWebElement SmsCode;
        [FindsBy(How = How.XPath, Using = "//div[@class='sms-bl__inner']//button[.='Подтвердить']")]
        public IWebElement SubmitButton;
        [FindsBy(How = How.Id, Using = "notyetregistered")]
        public IWebElement Notyetreg;

        
        // "//div[@class='auth-bl']//button[.='Войти']"
        public bool IsOnThisPage()

            //проверка поля телефон, когда находишься на странице авторизации
        {
            return IsElementPresent(By.Name("phone"));
        }

        public bool IsOnThisPageAlert()
        {
            return IsElementPresent(By.CssSelector(".reg-step__valid"));
            //проверка по появившейся валидахе
        }
        
    }
}