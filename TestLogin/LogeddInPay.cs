using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;

namespace Modul
{
    class LogeddInPay : Base
    {


        [Test, TestCaseSource("StaffCredentials")]
        public void LoggedInToPay(AccountData account)
            //пользователь с деньгами
        {

            app.Auth.LoginWithSms(account);
            Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");
            Assert.IsTrue(app.ActionOnDash.IsAccountBalance(), "Have Link Balance");
            //app.ActionOnDash.GoToMyAccount();
            app.Auth.LoginOut();
            Assert.IsTrue(app.Auth.IsLoginOut(), "Lending");
        }
        public static IEnumerable<AccountData> StaffCredentials()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"data\StaffCredentials.json"));
        }

    }
}
