using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.PhantomJS;
using NUnit.Framework;

namespace Modul
{

    [TestFixture()]

    public class Base
    {
        protected IWebDriver wd;

        [SetUp]

        public void StartBrowser()
        {
            wd = WebDriverFactory.GetDriver(DesiredCapabilities.Chrome());
            wd.Navigate().GoToUrl("https://low.modulbank.ru/login");


        }


        protected void ImplicitlyWait()
        //неявное ожидание
        {
            wd.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }

        protected void LoginWithoutSms(string phone, string password)
        // метод для негативного теста, до получения смс кода 
        {
            wd.FindElement(By.Name("phone")).Click();
            wd.FindElement(By.Name("phone")).Clear();
            wd.FindElement(By.Name("phone")).SendKeys(phone);
            wd.FindElement(By.Name("password")).Click();
            wd.FindElement(By.Name("password")).Clear();
            wd.FindElement(By.Name("password")).SendKeys(password);
            wd.FindElement(By.XPath("//div[@class='auth-bl']//button[.='Войти']")).Click();

        }
        protected void LoginWithSms(string phone, string password, string smscode)
        // метод для теста с получением смс кода 
        {
            wd.FindElement(By.Name("phone")).Click();
            wd.FindElement(By.Name("phone")).Clear();
            wd.FindElement(By.Name("phone")).SendKeys(phone);
            wd.FindElement(By.Name("password")).Click();
            wd.FindElement(By.Name("password")).Clear();
            wd.FindElement(By.Name("password")).SendKeys(password);
            wd.FindElement(By.XPath("//div[@class='auth-bl']//button[.='Войти']")).Click();
            wd.FindElement(By.XPath("//div[@class='sms-bl__inner']/div/input")).Click();
            wd.FindElement(By.XPath("//div[@class='sms-bl__inner']/div/input")).Clear();
            wd.FindElement(By.XPath("//div[@class='sms-bl__inner']/div/input")).SendKeys(smscode);
            wd.FindElement(By.XPath("//div[@class='sms-bl__inner']//button[.='Подтвердить']")).Click();
        }

        protected bool IsNotLoginIn()
        //проверка поля телефон, когда находишься на странице авторизации
        {
            return IsElementPresent(By.Name("phone"));
        }
        protected bool IsLoginIn()
        // проверка элемента "выйти", когда внутри
        {
            return IsElementPresent(By.CssSelector("a.b-leftmenu__exit"));
        }

        protected bool IsLoginOut()
        // проверка выхода, когда разлогинился и попал на лендинг
        {
            return IsElementPresent(By.LinkText("Личный кабинет"));
        }

        protected bool IsElementPresent(By by)
        //инициализируем метод проверки по элементу
        {
            return wd.FindElements(by).Count > 0;

        }

        protected void LoginOut()
        // разлогин.
        {
            wd.FindElement(By.CssSelector("a.b-leftmenu__exit")).Click();
        }



    }
}
