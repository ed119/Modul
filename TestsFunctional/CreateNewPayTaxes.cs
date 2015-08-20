using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Modul
{
    [TestFixture()]
    public class CreateNewPayTaxes : Base
    {
        [Test, TestCaseSource("StaffCredentials")]
        public void CreateNewPayTaxesTest(AccountData account)
        {
            app.Auth.LoginWithSms(account);
            Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");
            app.ActionOnDash.PassToPayments();
            app.ActionOnPay.FillFormForTaxes(account);
            Assert.IsTrue(app.ActionOnPay.IhaveRepeatPayLink(), "I subscribe new payment");
            //app.Auth.LoginOut();
            //Assert.IsTrue(app.Auth.IsNotLoginIn(), "LoginPage");
        }

        public static IEnumerable<AccountData> StaffCredentials()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"data\StaffCredentials.json"));
        }
    }
}