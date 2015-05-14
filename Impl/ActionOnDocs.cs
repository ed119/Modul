using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Modul
{
    public class ActionOnDocuments : BaseModul
    {
        public ActionOnDocuments(PagesCollection pages)
            : base(pages)
        { 
        }
        //добавляю тестовый док
        public void AttachedNewDoc()
        {
            pages.Documents.UploadFileIco.SendKeys("C:\\Users\\Эдуард\\Pictures\\для тестов\\testimage.jpg");
        }

        public void DeleteLastDoc()
        {
            pages.Documents.IcoDeleteFile.Click();
            pages.Documents.AlButtonDelete.Click();
        }

        public bool ICanUpload()
        {
            return pages.Documents.ElementIsVisible();

        }

        public bool NewFileLoaded()
        {
            return pages.Documents.FileIsLoaded();
        }

        public bool PageIsLoaded()
        {
            return pages.Documents.IsOnThisPage();
        }

        public bool ElementIsDownloaded()
        {
            return pages.Documents.ElementDownloaded();
        }

    }
}
