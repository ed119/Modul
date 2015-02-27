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

            app.Auth.ImplicitlyWait();
            //не забыть бы что здесь неявное ожидание в тесте
            app.Auth.LoginWithSms(account);
            Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");            
            app.Auth.LoginOut();
            Assert.IsTrue(app.Auth.IsLoginOut(), "Lending");
         }

    }
}
