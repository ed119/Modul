﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Modul
{
    public class AnyPage
    {
        private PageManager pageManager;

        public AnyPage(PageManager pageManager)
        {
            this.pageManager = pageManager;
        }
        public bool IsElementPresent(By by)
        {
            return pageManager.driver.FindElements(by).Count > 0;
        }
    }
}