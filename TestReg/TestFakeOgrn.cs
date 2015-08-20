//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using NUnit.Framework;

//namespace Modul
//{
//    [TestFixture()]
//    internal class TestFakeOgrn : Base
//    {
//        [Test, TestCaseSource("DataForReg")]
//        public void TestRegWithFakeOgrn(AccountData account)
//        {
//            app.ActionOnReg.GoToStartReg(account);
//            app.ActionOnReg.RegWithFakeOgrn(account);
//            Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");

//        }

//        public static IEnumerable<AccountData> DataForReg()
//        {
//            return JsonConvert.DeserializeObject<List<AccountData>>(
//                File.ReadAllText(@"data\DataForReg.json"));
//        }
//    }
//}
