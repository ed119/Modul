using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class DashBoardPage : AnyPage
    {
        public DashBoardPage(PagesCollection pageManager)
            : base(pageManager)
            //why there manager?
            // Y base?
        {
        }
        //icon cases left menu
        [FindsBy(How = How.CssSelector, Using = ".b-leftmenu__item.b-leftmenu__item--occasions.b-leftmenu__item--active")]
        public IWebElement CasesIcon;


        //icon docs left menu
        [FindsBy(How = How.Id, Using = "docsURL")]
        public IWebElement LinkDocs;

        //иконка банк левое меню
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[1]/div/div[2]/div[2]/a[2]/div")]
        public IWebElement BankIcon;

        // иконка в хедере "создать новый платеж"
        [FindsBy(How = How.CssSelector, Using = ".b-db-icon.b-db-icon--payment")] 
        public IWebElement CreateNewPayment;


        //ссылка платеж в меню, после нажатия на иконку банк
        [FindsBy(How = How.LinkText, Using = "Платежи")]
        public IWebElement LinkPayments;

        

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div/a/div[1]/span[1]")]
        public IWebElement LinkAccountbalance;
        //если вошел и у пользователя есть счет, элемент "Остаток на счетах"
        

        [FindsBy(How = How.CssSelector, Using = ".b-leftmenu__exit")]
        public IWebElement LogoutLink;
        //выход

        [FindsBy(How = How.CssSelector, Using = "div.b-db-header__right > div.b-db-header__rightlink > div.b-db-header__rightlink__inner > span.b-db-header__link")]
        public IWebElement IconSetTask;
        //элемемент "поставить задачу"

         [FindsBy(How = How.XPath, Using = "//div[@class='dashboard-add-theme']/div/div[1]/input")]
        public IWebElement HeaderTask;
        // элемент "Тема задачи"

         [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[3]/div/div[1]/div/div[2]/fileupload/div[1]/div/div")]
         public IWebElement BodyTask;
        // элемент тело задачи




         [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[3]/div/div[1]/div/div[2]/fileupload/div[2]/button")]
         public IWebElement ButtonSendTask;
        //кнопка "отправить" при создании таска
        
        

        public bool IsOnThisPage()
            
        {
            return IsElementPresent(By.CssSelector(".b-leftmenu__exit"));
        }

        //ниже буду добавлять проверки

        public bool HaveHeaderTask()
            //окно постановки задачи открылось
        {
            return IsElementPresent(By.CssSelector(".b-addinfo__textarea.ng-pristine.ng-untouched.ng-valid.ng-valid-maxlength"));
        }

        public bool HaveAccountBalanceLink()
            //есть элемент "Остаток на счетах"
        {
            return IsElementPresent(By.XPath("html/body/div[1]/div/div[2]/div/div/a/div[1]/span[1]"));
            //return IsElementPresent(By.XPath("//div[@class='dashboard-add-theme']/div/div[1]/input"));
        }
    }

}