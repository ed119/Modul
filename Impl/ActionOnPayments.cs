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
           System.Threading.Thread.Sleep(2000);
           pages.Payments.FieldDescription.Clear();
           pages.Payments.FieldDescription.SendKeys(account.FieldDescription);
           pages.Payments.FieldAmount.Clear();
           pages.Payments.FieldAmount.SendKeys(account.FieldAmount);
           pages.Payments.ButtonNextToSubscribe.Click();
           System.Threading.Thread.Sleep(2000);
           pages.Payments.ButtonSubscribe.Click();
        

        }

        public void FillInFormPayment100k(AccountData account)
        {
            pages.Payments.FieldCorrName.Clear();
            pages.Payments.FieldCorrName.SendKeys(account.FieldCorrName);
            pages.Payments.DropOldCorr.Click();
            System.Threading.Thread.Sleep(2000);
            pages.Payments.FieldDescription.Clear();
            pages.Payments.FieldDescription.SendKeys(account.FieldDescription);
            System.Threading.Thread.Sleep(2000);
            pages.Payments.FieldAmount.Clear();
            pages.Payments.FieldAmount.SendKeys(account.FieldAmount);
            pages.Payments.ButtonNextToSubscribe.Click();
            pages.Payments.ButtonSubscribe.Click();
            System.Threading.Thread.Sleep(500);
            pages.Payments.PaySmsField.SendKeys(account.smscode);
            System.Threading.Thread.Sleep(500);
            pages.Payments.PayConfirmButton.Click();

        }

        public void FillFormForTaxes(AccountData account)
        {
            pages.Payments.FieldCorrName.Clear();
            pages.Payments.FieldCorrName.SendKeys(account.FieldCorrNameTaxes);
            pages.Payments.DropTaxLink.Click();
            System.Threading.Thread.Sleep(2000);
            pages.Payments.KbkField.Clear();
            pages.Payments.KbkField.SendKeys(account.KbkTaxes);
            pages.Payments.FieldDescription.Clear();
            pages.Payments.FieldDescription.SendKeys(account.FieldDescription);
            System.Threading.Thread.Sleep(2000);
            pages.Payments.FieldAmount.Clear();
            pages.Payments.FieldAmount.SendKeys(account.FieldAmount);
            pages.Payments.ButtonNextToSubscribe.Click();
            pages.Payments.ButtonSubscribe.Click();
            //System.Threading.Thread.Sleep(500);
            //pages.Payments.PaySmsField.SendKeys(account.smscode);
            System.Threading.Thread.Sleep(3000);
            pages.Payments.ButtonSubscribe.Click();
            System.Threading.Thread.Sleep(1000);
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
