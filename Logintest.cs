using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;

namespace Modul
{

    [TestFixture()]
    public class ModulTests
    {
        private IWebDriver wd;
       
        [SetUp]
        public void StartBrowser()
        {
            wd = new ChromeDriver();
            wd.Navigate().GoToUrl("https://low.modulbank.ru/login");
            
            
        }
        
            
            [Test()]
        public void LoginTest()
        {

            ImplicitlyWait();
            //не забыть бы что здесь неявное ожидание в тесте
            Login();

            ImplicitlyWait();
            //блок "неявное ожидание" надо добавлять перед каждым блоком, а то срабатывает только перед одним

            LoginOut();
         }

        private void ImplicitlyWait()
        {
            wd.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }
       
        private void Login()
        {
        wd.FindElement(By.Name("phone")).Click();
        wd.FindElement(By.Name("phone")).Clear();
        wd.FindElement(By.Name("phone")).SendKeys("+7 927-445-06-47");
        wd.FindElement(By.Name("password")).Click();
        wd.FindElement(By.Name("password")).Clear();
        wd.FindElement(By.Name("password")).SendKeys("Maxpass5");
        wd.FindElement(By.XPath("//div[@class='auth-bl']//button[.='Войти']")).Click();
        wd.FindElement(By.XPath("//div[@class='sms-bl__inner']/div/input")).Click();
        wd.FindElement(By.XPath("//div[@class='sms-bl__inner']/div/input")).Clear();
        wd.FindElement(By.XPath("//div[@class='sms-bl__inner']/div/input")).SendKeys("1111");
        wd.FindElement(By.XPath("//div[@class='sms-bl__inner']//button[.='Подтвердить']")).Click();
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
