using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Modul
{

    class CreateNewPayment100k : Base
    {


        [Test, TestCaseSource("StaffCreentials100k")]
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
            app.ActionOnPay.FillInFormPayment100k(account);
            Assert.IsTrue(app.ActionOnPay.IhaveRepeatPayLink(), "I subscribe new payment");
            app.Auth.LoginOut();
            Assert.IsTrue(app.Auth.IsNotLoginIn(), "LoginPage");


        }
        public static IEnumerable<AccountData> StaffCreentials100k()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"data\StaffCreentials100k.json"));
        }
    }
}