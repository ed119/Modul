using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;

namespace Modul
{
     [TestFixture()]
    class SetTask : Base
    {


        [Test, TestCaseSource("StaffCredentials")]
        public void TestSetTask(AccountData account)
        //пользователь с деньгами
        {

            app.Auth.LoginWithSms(account);
            Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");
            app.ActionOnDash.SetTask();
            Assert.IsTrue(app.ActionOnDash.IsHeaderTask(), "I have Header Task");
            app.ActionOnDash.CreateTask();
            app.Auth.LoginOut();
            Assert.IsTrue(app.Auth.IsNotLoginIn(), "LoginPage");
        }
        public static IEnumerable<AccountData> StaffCredentials()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"data\StaffCredentials.json"));
        }

    }
}
