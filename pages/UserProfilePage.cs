using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class UserProfilePage : InternalPage
    {
        public UserProfilePage(PagesCollection pageManager)
            : base(pageManager)
        {
        }
    }
}