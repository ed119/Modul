using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;

namespace Modul
{

    [TestFixture()]
    public class LoginTestsNegative : Base
    {


        [Test, TestCaseSource("InvalidCredentials")]
        public void LoginTestWithInvalidCredentials(AccountData account)
        {

            app.Auth.ImplicitlyWait();
            //не забыть бы что здесь неявное ожидание в тесте
            app.Auth.LoginWithoutSms(account);
            Assert.IsTrue(app.Auth.IsNotLoginIn(), "Not logged in");
            //раз не лендинг не попадаем, то проверка по полю "телефон"
        }
            
      public static IEnumerable<AccountData> InvalidCredentials()
            {
                return JsonConvert.DeserializeObject<List<AccountData>>(
                    File.ReadAllText(@"data\invalidCredentials.json"));
            }

    }
           
}

