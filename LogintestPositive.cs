using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;

namespace Modul
{

    [TestFixture()]
    public class LoginTestsPositive : Base
    {
     
            
            [Test()]
        public void LoginTestWithValidCredentials()
        {

            ImplicitlyWait();
            //не забыть бы что здесь неявное ожидание в тесте
            LoginWithSms("9274450647", "Maxpass5", "1111");
            Assert.IsTrue(IsLoginIn(), "Logged in");            
            LoginOut();
            Assert.IsTrue(IsLoginOut(), "Lending");
         }

    }
}
