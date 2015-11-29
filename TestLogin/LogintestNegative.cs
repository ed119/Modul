using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;

namespace Tooktodo
{

    [TestFixture()]
    public class LoginTestsNegative : Base
    {


        [Test, TestCaseSource("InvalidCredentials")]
        public void LoginTestWithInvalidCredentials(AccountData account)
        {


            //app.Auth.LoginWithoutSms(account);
            //Assert.IsTrue(app.Auth.IsNotLoginAlert(), "Not logged in");
            //проверка по появившейся валидахе
        }
            
      //public static IEnumerable<AccountData> InvalidCredentials()
      //      {
      //          return JsonConvert.DeserializeObject<List<AccountData>>(
      //              File.ReadAllText(@"data\invalidCredentials.json"));
      //      }

    }
           
}

