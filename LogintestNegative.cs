using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;

namespace Modul
{

    [TestFixture()]
    public class LoginTestsNegative
    {
        private IWebDriver wd;

        [SetUp]
        public void StartBrowser()
        {
            wd = new ChromeDriver();
            wd.Navigate().GoToUrl("https://low.modulbank.ru/login");


        }


        [Test()]
        public void LoginTestWithInvalidCredentials()
        {

            ImplicitlyWait();
            //не забыть бы что здесь неявное ожидание в тесте
            Login("9274450648", "Maxpass5");
            Assert.IsTrue(IsNotLoginIn(), "Not logged in");
            //раз не лендинг не попадаем, то проверка по полю "телефон"
        }

        private void ImplicitlyWait()
        {
            wd.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }

        private void Login(string phone, string password)
        {
            wd.FindElement(By.Name("phone")).Click();
            wd.FindElement(By.Name("phone")).Clear();
            wd.FindElement(By.Name("phone")).SendKeys(phone);
            wd.FindElement(By.Name("password")).Click();
            wd.FindElement(By.Name("password")).Clear();
            wd.FindElement(By.Name("password")).SendKeys(password);
            wd.FindElement(By.XPath("//div[@class='auth-bl']//button[.='Войти']")).Click();
           
        }

        private bool IsNotLoginIn()
        {
            return IsElementPresent(By.Name("phone"));
        }
        private bool IsLoginIn()
        {
            return IsElementPresent(By.CssSelector("a.b-leftmenu__exit"));
        }

        private bool IsLoginOut()
        {
            return IsElementPresent(By.LinkText("Личный кабинет"));
        }

        private bool IsElementPresent(By by)
        {
            return wd.FindElements(by).Count > 0;

        }

        private void LoginOut()
        {
            wd.FindElement(By.CssSelector("a.b-leftmenu__exit")).Click();
        }


        [TearDown]
        public void StopBrowser()
        {
            if (wd != null)
            {
                wd.Quit();
                wd = null;
            }

        }
    }
}
