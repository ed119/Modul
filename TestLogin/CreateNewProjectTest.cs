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
    class CreateNewProjectTest : Base
    {
          [Test, TestCaseSource("DataForReg")]
         public void CreateNewProject(AccountData account)
         {
             app.Auth.SignInToCreateProj(account);
             Thread.Sleep(3000);
             app.Dash.CreateNewProject();
             app.Dash.FillingFormProject();

         }
          public static IEnumerable<AccountData> DataForReg()
          {
              return JsonConvert.DeserializeObject<List<AccountData>>(
                  File.ReadAllText(@"data\DataForReg.json"));
          }
    }
}
