using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;

namespace Modul
{
    [TestFixture()]
    class TestWithOgrn : Base
    {
         [Test, TestCaseSource("DataForReg")]

         public void TestWithOgrnData(AccountData account)
         {
             app.ActionOnReg.GoToStartReg(account);
             app.ActionOnReg.RegWithO(account);
             Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");

         }

         public static IEnumerable<AccountData> DataForReg()
         {
             return JsonConvert.DeserializeObject<List<AccountData>>(
                 File.ReadAllText(@"data\DataForReg.json"));
         }
    }
}
    

