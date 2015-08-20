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
    public class TestRegNotMyCompany : Base
    {
        [Test, TestCaseSource("DataForReg")]
        public void TestRegNotMyComp(AccountData account)
        {
            app.ActionOnReg.GoToStartReg(account);
            app.ActionOnReg.RegItsNotMyCompany(account);
            Assert.IsTrue(app.ActionOnReg.CallToUsLink(), "Свяжитесь с нами");

        }

        public static IEnumerable<AccountData> DataForReg()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"data\DataForReg.json"));
        }
    }
}