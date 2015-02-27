using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;

namespace Modul
{

    [TestFixture()]
    public class LoginTestsNegative : Base
    {
      

        [Test()]
        public void LoginTestWithInvalidCredentials()
        {
            AccountData account = new AccountData
            {
                phone = "9274450648",
                password = "Maxpass5"

            };

            ImplicitlyWait();
            //не забыть бы что здесь неявное ожидание в тесте
            LoginWithoutSms(account);
            Assert.IsTrue(IsNotLoginIn(), "Not logged in");
            //раз не лендинг не попадаем, то проверка по полю "телефон"
        }

    
    }
}
