using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Tooktodo
{
    [TestFixture()]
    class RegistrationTest : Base
    {
        [Test, TestCaseSource("DataForReg")]
        public void RegTest(AccountData account)
        {
            app.Auth.Registration(account);
            Thread.Sleep(20000);
            app.Auth.GoToMyMail(account);
            //app.Auth.SignInAfterConfirm(account);


        }
        public static IEnumerable<AccountData> DataForReg()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"data\DataForReg.json"));
        }
    }
}
