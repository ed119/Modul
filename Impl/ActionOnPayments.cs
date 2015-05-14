using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class ActionOnPayments : BaseModul
    {
        public ActionOnPayments(PagesCollection pages): base(pages)
        {
        }

        public void FillInFormPayment(AccountData account)
           //автозаполнение формы, с уже готовой организацией
        {
           pages.Payments.FieldCorrName.Clear();
           pages.Payments.FieldCorrName.SendKeys(account.FieldCorrName);
           pages.Payments.DropOldCorr.Click();
           pages.Payments.FieldDescription.Clear();
           pages.Payments.FieldDescription.SendKeys(account.FieldDescription);
           pages.Payments.FieldAmount.Clear();
           pages.Payments.FieldAmount.SendKeys(account.FieldAmount);
           pages.Payments.ButtonNextToSubscribe.Click();
           pages.Payments.ButtonSubscribe.Click();
            //int.Parse - если строка корректная, то он превращает её в число
           //var FieldAmount = A;
           // if (A > 100000)
           //{
           //    //найти поле и сделать с ним  чегото
           //}

        }

        public void FillInFormPayment100k(AccountData account)
        {
            pages.Payments.FieldCorrName.Clear();
            pages.Payments.FieldCorrName.SendKeys(account.FieldCorrName);
            pages.Payments.DropOldCorr.Click();
            pages.Payments.FieldDescription.Clear();
            pages.Payments.FieldDescription.SendKeys("тут название платежа");
            pages.Payments.FieldAmount.Clear();
            pages.Payments.FieldAmount.SendKeys(account.FieldAmount);
            pages.Payments.ButtonNextToSubscribe.Click();
            pages.Payments.ButtonSubscribe.Click();
            pages.Payments.PaySmsField.SendKeys("1111");
            pages.Payments.PayConfirmButton.Click();

        }
        
        
        public void CreateNewPayment()
        {
            pages.Payments.NewPaymentLink.Click();
        }
        
        
        //проверки
        public bool IhaveLinkNewPay()
        {
            return pages.Payments.HaveLinkNewPayments();
        }

        public bool IhaveFieldCorrName()
        {
            return pages.Payments.HaveFieldCorrName();
        }

        public bool IhaveRepeatPayLink()
        {
            return pages.Payments.HaveRepeatPaymentsLink();
        }

        //public IWebElement A { get; set; }
    }
}
