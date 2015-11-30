

using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Tooktodo
{
    public class AuthModul : BaseModul
    {
        

        public AuthModul(PagesCollection pages)
            : base(pages)
        {
            
            
        }


        public void Registration(AccountData account)
        {
            pages.Login.TabRegistration.Click();
            pages.Login.NameField.Clear();
            pages.Login.NameField.SendKeys("Test");
            pages.Login.LastNameField.Clear();
            pages.Login.LastNameField.SendKeys("Tests");
            pages.Login.EmailField.Clear();
            pages.Login.EmailField.SendKeys("igtest510@yandex.ru");
            pages.Login.PasswordField.Clear();
            pages.Login.PasswordField.SendKeys("123456");
            pages.Login.SubmitButton.Click();
            
        }

        public void GoToMyMail(AccountData account)
        {
            
             
            pages.driver.Navigate().GoToUrl("https://mail.yandex.ru/");
            pages.Mail.LoginElement.Clear();
            pages.Mail.LoginElement.SendKeys("igtest510");
            pages.Mail.PasswordElement.Clear();
            pages.Mail.PasswordElement.SendKeys("123123");
            pages.Mail.EnterButton.Click();
            pages.Mail.MyLetterElement.Click();
            pages.Mail.BeginWorkButton.Click();

        }

        public void SignIn(AccountData account)
        {
            pages.Login.EmailSigninElement.Clear();
            pages.Login.EmailSigninElement.SendKeys("emustakimow@yandex.ru");
            pages.Login.PassSigninElement.Clear();
            pages.Login.PassSigninElement.SendKeys("123456");
            pages.Login.SinginButtonElement.Click();
        }

        public void SignInAfterConfirm(AccountData account)
        {
            pages.driver.Navigate().GoToUrl("http://tooktodo.igstest.ru/login");
            pages.Login.EmailSigninElement.Clear();
            pages.Login.EmailSigninElement.SendKeys("igtest509@yandex.ru");
            pages.Login.PassSigninElement.Clear();
            pages.Login.PassSigninElement.SendKeys("123456");
            pages.Login.SinginButtonElement.Click();
        }

        public void SignOut(AccountData account)
        {
            
            pages.Dash.DropDownElement.Click();
            pages.Dash.ExitDropdownElement.Click();
        }

        public void SignInToCreateProj(AccountData account)
        {
            pages.Login.EmailSigninElement.Clear();
            pages.Login.EmailSigninElement.SendKeys("igtest509@yandex.ru");
            pages.Login.PassSigninElement.Clear();
            pages.Login.PassSigninElement.SendKeys("123456");
            pages.Login.SinginButtonElement.Click();
        }


























































        //public void GoToStartReg (AccountData accont)
        //    //перешел на начало регистрации
        //{
        //    pages.Login.Notyetreg.Click();
        //}

        //public void RegWithOutOgrn (AccountData accont)
        //{
        //    pages.RegN.SurNameReg.Clear();
        //    pages.RegN.SurNameReg.SendKeys();

        //}

        //    public bool IsLoginIn()
        //    // проверка элемента "выйти", когда внутри
        //    {
        //        return pages.DashBoard.IsOnThisPage();
        //    }

        //    public bool IsNotLoginIn()
        //    //проверка поля телефон, когда находишься на странице авторизации
        //    {
        //        return pages.Login.IsOnThisPage();
        //    }

        //    public bool IsNotLoginAlert()
        //    {
        //        return pages.Login.IsOnThisPageAlert();
        //        //по цсс селектору поле с валидахой, когда пароль не прошел
        //    }

        //     public bool IsLoginOut()
        //    // проверка выхода, когда разлогинился и попал на лендинг
        //    {
        //        return pages.Lending.IsOnThisPage();
        //         //здесь нужен лендинг
        //    }

        //     public void LoginOut()
        //    // разлогин.
        //    {
        //       pages.DashBoard.LogoutLink.Click();
        //    }

        //}
    }
}