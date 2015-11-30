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
    public class LoginTestsPositive : Base
    {
        

            [Test, TestCaseSource("DataForReg")]
        public void LoginTestWithValidCredentials(AccountData account)
            
            {
                app.Auth.SignIn(account);
                Thread.Sleep(5000);
                app.Auth.SignOut(account);
                
                //Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");

                //app.Auth.LoginOut();
                //Assert.IsTrue(app.Auth.IsNotLoginIn(), "LoginPage"); 
            
         }

            public static IEnumerable<AccountData> DataForReg()
            {
                return JsonConvert.DeserializeObject<List<AccountData>>(
                    File.ReadAllText(@"data\DataForReg.json"));
            }

    }
}
