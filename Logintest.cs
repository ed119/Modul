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
            Login("9274450647","Maxpass5", "1111");

            //ImplicitlyWait();
            //блок "неявное ожидание" надо добавлять перед каждым блоком, а то срабатывает только перед одним, 
            //или нет, хз, надо будет уточнить

            LoginOut();
         }

        private void ImplicitlyWait()
        {
            wd.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }

        private void Login(string phone, string password, string smscode)
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
