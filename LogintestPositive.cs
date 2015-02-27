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
            AccountData account = new AccountData
            {
                phone = "9274450647",
                password = "Maxpass5",
                smscode = "1111"

            };

            ImplicitlyWait();
            //не забыть бы что здесь неявное ожидание в тесте
            LoginWithSms(account);
            Assert.IsTrue(IsLoginIn(), "Logged in");            
            LoginOut();
            Assert.IsTrue(IsLoginOut(), "Lending");
         }

    }
}
