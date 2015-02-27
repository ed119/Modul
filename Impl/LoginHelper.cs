using System;
using OpenQA.Selenium;

namespace Modul
{
    public class LoginHelper
    {
        private ApplicationManager manager;
        private IWebDriver wd;

        public LoginHelper(ApplicationManager manager)
        {
            this.manager = manager;
            this.wd = manager.Driver;
        }
        public void LoginWithoutSms(AccountData account)
        // метод для негативного теста, до получения смс кода 
        {
            wd.FindElement(By.Name("phone")).Click();
            wd.FindElement(By.Name("phone")).Clear();
            wd.FindElement(By.Name("phone")).SendKeys(account.phone);
            wd.FindElement(By.Name("password")).Click();
            wd.FindElement(By.Name("password")).Clear();
            wd.FindElement(By.Name("password")).SendKeys(account.password);
            wd.FindElement(By.XPath("//div[@class='auth-bl']//button[.='Войти']")).Click();

        }
        public void LoginWithSms(AccountData account)
        // метод для теста с получением смс кода 
        {
            wd.FindElement(By.Name("phone")).Click();
            wd.FindElement(By.Name("phone")).Clear();
            wd.FindElement(By.Name("phone")).SendKeys(account.phone);
            wd.FindElement(By.Name("password")).Click();
            wd.FindElement(By.Name("password")).Clear();
            wd.FindElement(By.Name("password")).SendKeys(account.password);
            wd.FindElement(By.XPath("//div[@class='auth-bl']//button[.='Войти']")).Click();
            wd.FindElement(By.XPath("//div[@class='sms-bl__inner']/div/input")).Click();
            wd.FindElement(By.XPath("//div[@class='sms-bl__inner']/div/input")).Clear();
            wd.FindElement(By.XPath("//div[@class='sms-bl__inner']/div/input")).SendKeys(account.smscode);
            wd.FindElement(By.XPath("//div[@class='sms-bl__inner']//button[.='Подтвердить']")).Click();
        }
        public void ImplicitlyWait()
        //неявное ожидание, пока сюда, но надо создать отдельный хелпер
        {
            wd.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
        }
        public bool IsNotLoginIn()
        //проверка поля телефон, когда находишься на странице авторизации
        {
            return IsElementPresent(By.Name("phone"));
        }
        public bool IsLoginIn()
        // проверка элемента "выйти", когда внутри
        {
            return IsElementPresent(By.CssSelector("a.b-leftmenu__exit"));
        }

        public bool IsLoginOut()
        // проверка выхода, когда разлогинился и попал на лендинг
        {
            return IsElementPresent(By.LinkText("Личный кабинет"));
        }

        public bool IsElementPresent(By by)
        //инициализируем метод проверки по элементу
        {
            return wd.FindElements(by).Count > 0;

        }

        public void LoginOut()
        // разлогин.
        {
            wd.FindElement(By.CssSelector("a.b-leftmenu__exit")).Click();
        }




    }
}

