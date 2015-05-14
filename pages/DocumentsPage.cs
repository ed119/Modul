using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
   public class DocumentsPage : AnyPage
    {
        public DocumentsPage(PagesCollection pageManager) : base(pageManager)
    {
    }
    // загрузка файлов
     [FindsBy(How = How.Id, Using = "uploaded-files__input")]
        public IWebElement UploadFileIco;

     [FindsBy(How = How.CssSelector, Using = ".docs-head")]
     public IWebElement HeaderLoadedFile;

    //иконка самого последнего загруженного документа
     [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div/div[3]/div[2]/article[1]/div/div[1]/a/span[1]/i/span")]
     public IWebElement IcoFaceOfDoc;

    //последний документ будет удаляться
     [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div/div[3]/div[2]/article[1]/div/div[3]/div/span[1]")]
     public IWebElement IcoDeleteFile;

    //кнопка алерта удалить
     [FindsBy(How = How.CssSelector, Using = ".btn.btn-action")]
     public IWebElement AlButtonDelete;



    public bool IsOnThisPage()
     {
         return IsElementPresent(By.CssSelector(".docs-head"));
     }

     public bool FileIsLoaded()
     {
         return IsElementPresent(By.LinkText("testimage.jpg"));
     }

    public bool ElementIsVisible()//элементы удаления на всех доках
     {
         return IsElementPresent(By.CssSelector(".docs-it__action.icon.icon-del.ng-scope"));
     }

       public bool ElementDownloaded()
    {
        return IsElementPresent(By.XPath("html/body/div[1]/div/div[2]/div/div/div[3]/div[2]/article[1]/div/div[1]/a/span[1]/i/span"));
    }

    }
}
