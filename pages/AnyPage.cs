using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Modul
{
    public class AnyPage
    {
        private PagesCollection pageManager;

        public AnyPage(PagesCollection pageManager)
        {
            this.pageManager = pageManager;
        }
        public bool IsElementPresent(By by)
        {
            return pageManager.driver.FindElements(by).Count > 0;
        }
    }
}