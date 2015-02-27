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

            app.Auth.ImplicitlyWait(); 
            //не забыть бы что здесь неявное ожидание в тесте
            app.Auth.LoginWithoutSms(account);
            Assert.IsTrue(app.Auth.IsNotLoginIn(), "Not logged in");
            //раз не лендинг не попадаем, то проверка по полю "телефон"
        }

    
    }
}
