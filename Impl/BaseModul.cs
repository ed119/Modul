using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tooktodo
{
    public abstract class BaseModul
    {
        protected PagesCollection pages;

        protected BaseModul(PagesCollection pages)
        {
            this.pages = pages;
        }

        
    }
}
