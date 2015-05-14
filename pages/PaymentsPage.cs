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
        [FindsBy(How = How.XPath, Using = "//div[@class='payment-create__common-fields']//button[normalize-space(.)='Далее']")]
        public IWebElement ButtonNextToSubscribe;

        //кнопка "подписать платеж" (стр создания платежа)
        [FindsBy(How = How.XPath, Using = "//div[@class='b-dashboard__middle']//button[.='Подписать']")]
        public IWebElement ButtonSubscribe;

        //ЭТО УБРАТЬ! ПОКА ТАК!
        [FindsBy(How = How.LinkText, Using = "ооо проыпвпыв")]
        public IWebElement DropOldCorr;




        
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
            return IsElementPresent(By.LinkText("Повторить платеж"));
        }
    
    }

}
