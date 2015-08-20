using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Modul
{

    [TestFixture()]
    public class LoginTestsPositive : Base
    {
        

            [Test, TestCaseSource("ValidCredentials")]
        public void LoginTestWithValidCredentials(AccountData account)
            
            {
             
            app.Auth.LoginWithSms(account);
            Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");

            app.Auth.LoginOut();
            Assert.IsTrue(app.Auth.IsNotLoginIn(), "LoginPage"); 
            
         }
    
            public static IEnumerable<AccountData> ValidCredentials()
            {
                return JsonConvert.DeserializeObject<List<AccountData>>(
                    File.ReadAllText(@"data\validCredentials.json"));
            }

    }
}
