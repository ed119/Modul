using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class PaymentsPage : AnyPage
    {
        public PaymentsPage(PagesCollection pageManager) : base(pageManager)
        { }

        //поле смс код, после подписания платежа, оплата более 100 тыс
        [FindsBy(How = How.CssSelector, Using = ".input.group-input--input.input--small.ng-pristine.ng-valid.ng-isolate-scope.ng-valid-maxlength.ng-touched")]
        public IWebElement PaySmsField;

        //кнопка "подтвердить, после ввода смс кода, оплата более 100 тыс"
        [FindsBy(How = How.CssSelector, Using = ".btn.btn-green.btn--padd-middle.f-size-18")]
        public IWebElement PayConfirmButton;
        
        //ссылка "повторить платеж, после подписания платежки"
        [FindsBy(How = How.LinkText, Using = "Повторить платеж")]
        public IWebElement RepeatPaymentLink;

        //ссылка "новый платеж, на стартовой странице "платежи"
        [FindsBy(How = How.LinkText, Using = "Новый платеж")]
        public IWebElement NewPaymentLink;
    
    
        //поле "наименование получателя" на странице создания платежа
        [FindsBy(How = How.Name, Using = "CorrFullname")]
        public IWebElement FieldCorrName;

        //поле ввода переводимой суммы на странице создания платежа
        [FindsBy(How = How.Name, Using = "Amount")]
        public IWebElement FieldAmount;

        //поле ввода описания платежа (стр создания платежа)
        [FindsBy(How = How.Name, Using = "Description")]
        public IWebElement FieldDescription;

        //кнопка "далее" когда все заполнено (стр создания платежа)
        [FindsBy(How = How.CssSelector, Using = ".btn.btn-light-blue.btn--padd-middle")]
        public IWebElement ButtonNextToSubscribe;

        //кнопка "подписать платеж" (стр создания платежа)
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[3]/section/div[1]/div/div[1]/div[4]/div[1]/div/button")]
        public IWebElement ButtonSubscribe;

        
        [FindsBy(How = How.LinkText, Using = "ооо проыпвпыв")]
        public IWebElement DropOldCorr;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/section/section/div/div[1]/div/form/div[1]/div[3]/span[2]/label")] 
        public IWebElement RadioBtnTaxes;

        [FindsBy(How = How.LinkText, Using = "Межрайонная инспекция Федеральной налоговой службы №2 по Республике Адыгея")]
        public IWebElement DropTaxLink;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/section/section/div/div[1]/div/form/div[1]/div[8]/input")]
        public IWebElement KbkField;








        
        //отсюда проверки
        public bool HaveLinkNewPayments()
        {
            return IsElementPresent(By.LinkText("Новый платеж"));
        }

        public bool HaveFieldCorrName()
        {
            return IsElementPresent(By.Name("CorrFullname"));
        }

        public bool HaveRepeatPaymentsLink()
        {
            return IsElementPresent(By.XPath("html/body/div[1]/div/div[3]/section/div[1]/div/div[2]/div/a/span"));
        }
    
    }

}
