using System;
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;
using Newtonsoft.Json;

namespace Modul
{
     [TestFixture()]
    class uploadFile : Base
    {
        [Test, TestCaseSource("StaffCredentials")]
    public void TestUploadFile(AccountData account)
    {
        app.Auth.LoginWithSms(account);
        Assert.IsTrue(app.Auth.IsLoginIn(), "Logged in");
        app.ActionOnDash.PassToDocs();
        Assert.IsTrue(app.ActionOnDocs.PageIsLoaded(), "вижу шапку файлов");
        Assert.IsTrue(app.ActionOnDocs.ICanUpload(), "можно загружать");
        app.ActionOnDocs.AttachedNewDoc();
        Assert.IsTrue(app.ActionOnDocs.NewFileLoaded(), "новый файл загружен");
        Assert.IsTrue(app.ActionOnDocs.ElementIsDownloaded(), "вижу иконку загруженного файла");
        //app.ActionOnDocs.DeleteLastDoc();
        //Assert.IsFalse(app.ActionOnDocs.NewFileLoaded(), "новый файл загружен");
        
            
            
           
        //wd.FindElement(By.Id("docsURL")).Click();
        //wd.FindElement(By.Id("uploaded-files__input")).Click();
        //wd.FindElement(By.CssSelector("span.b-leftmenu__exit")).Click();

    }
        public static IEnumerable<AccountData> StaffCredentials()
        {
            return JsonConvert.DeserializeObject<List<AccountData>>(
                File.ReadAllText(@"data\StaffCredentials.json"));
        }
    }
}
