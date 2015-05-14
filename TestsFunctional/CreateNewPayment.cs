using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Modul
{
    class CreateNewPayment : Base
    {


        [Test, TestCaseSource("StaffCredentials")]
        //[TestCaseSource("CredentialsForPayments")]
        public void TestCreateNewPayment(AccountData account)
        //пользователь с деньгами
        {
         
                app.Auth.LoginWithSms(account);
                Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");
                app.ActionOnDash.PassToPayments();
                Assert.IsTrue(app.ActionOnPay.IhaveLinkNewPay(), "I`m on payments page");
                app.ActionOnPay.CreateNewPayment();
                Assert.IsTrue(app.ActionOnPay.IhaveFieldCorrName(), "I created a new payment");
                app.ActionOnPay.FillInFormPayment(account);
                Assert.IsTrue(app.ActionOnPay.IhaveRepeatPayLink(), "I subscribe new payment");
                app.Auth.LoginOut();
                Assert.IsTrue(app.Auth.IsNotLoginIn(), "LoginPage");
           
           
        }
        public static IEnumerable<AccountData> StaffCredentials()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"data\StaffCredentials.json"));
        }
            
            
            
            
            
            //{
        //    var creds = JsonConvert.DeserializeObject<List<AccountData>>(
        //        File.ReadAllText(@"data\Credentials123.json"));
        //    var text = File.ReadAllText(@"data\StaffCredentials.json");
        //    Debug.Print("Account DATA READ: " + text);
        //    return JsonConvert.DeserializeObject<List<AccountData>>(text);
        //}
        //public static IEnumerable<AccountData> CredentialsForPayments()
        //{
        //    return JsonConvert.DeserializeObject<List<AccountData>>
        //        (File.ReadAllText(@"data\CredentialsForPayments.json"));
        //}

    }
}
