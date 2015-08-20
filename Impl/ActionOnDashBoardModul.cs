using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class ActionOnDashBoard : BaseModul
    {

        public ActionOnDashBoard(PagesCollection pages)
            : base(pages)
        {

        }

        public void PassToDocs()
        {
            pages.DashBoard.CasesIcon.Click();
            pages.DashBoard.LinkDocs.Click();

        }
       
        public void PassToPayments()
        {
            pages.DashBoard.CreateNewPayment.Click();
            
        }
        
        
        public void SetTask()
    {
        
            pages.DashBoard.IconSetTask.Click();
            //pages.DashBoard.HeaderTask.SendKeys("Testtest");
            //pages.DashBoard.BodyTask.Clear();
            //pages.DashBoard.BodyTask.SendKeys("111");
            //pages.DashBoard.ButtonSendTask.Click();
    }

        public void CreateTask()
        {
            //pages.DashBoard.SetTask.Click();
            pages.DashBoard.HeaderTask.SendKeys("Testtest");
            pages.DashBoard.BodyTask.Clear();
            pages.DashBoard.BodyTask.SendKeys("111");
            pages.DashBoard.ButtonSendTask.Click();
        }

        public void GoToMyAccount()
        {
            pages.DashBoard.LinkAccountbalance.Click();
        }
        
        public bool IsHeaderTask()
            //проверка открылось ли окно по заголовку
        {
            return pages.DashBoard.HaveHeaderTask();
            
        }

        public bool IsAccountBalance()
        {
            return pages.DashBoard.HaveAccountBalanceLink();
        }

    }
}
