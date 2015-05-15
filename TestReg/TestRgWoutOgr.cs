using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;

namespace Modul
{
     [TestFixture()]
    public class TestRegWoutOgr : Base
    {
         [Test, TestCaseSource("DataForReg")]

         public void TestWithOutOgrn(AccountData account)
         {
             app.ActionOnReg.GoToStartReg(account);
             app.ActionOnReg.RegWithOutOgrn(account);
             Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");

         }

         public static IEnumerable<AccountData> DataForReg()
         {
             return JsonConvert.DeserializeObject<List<AccountData>>(
                 File.ReadAllText(@"data\DataForReg.json"));
         }
    }
}
