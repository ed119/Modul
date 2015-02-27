using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;

namespace Modul
{

    [TestFixture()]
    public class LoginTestsPositive : Base
    {


            [Test, TestCaseSource("ValidCredentials")]
        public void LoginTestWithValidCredentials(AccountData account)
        {
            
            app.Auth.ImplicitlyWait();
            //не забыть бы что здесь неявное ожидание в тесте
            app.Auth.LoginWithSms(account);
            Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");            
            app.Auth.LoginOut();
            Assert.IsTrue(app.Auth.IsLoginOut(), "Lending");
         }
            public static IEnumerable<AccountData> ValidCredentials()
            {
                return JsonConvert.DeserializeObject<List<AccountData>>(
                    File.ReadAllText(@"data\validCredentials.json"));
            }

    }
}
