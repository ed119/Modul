﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class LoginHelper
    {
        public ApplicationManager manager;
        public PageManager pages;

        public LoginHelper(PageManager manager)
        {
            //this.manager = manager;
            this.pages = manager;
        }

        public void LoginWithoutSms(AccountData account)
        {
            pages.Login.PhoneField.SendKeys(account.phone);
            pages.Login.PasswordField.SendKeys(account.password);
            pages.Login.GiveMeCode.Click();
        }

        public void LoginWithSms(AccountData account)
        {
            pages.Login.PhoneField.SendKeys(account.phone);
            pages.Login.PasswordField.SendKeys(account.password);
            pages.Login.GiveMeCode.Click();
            pages.Login.SmsCode.SendKeys(account.smscode);
            pages.Login.SubmitButton.Click();
        }

        
        public bool IsLoginIn()
        // проверка элемента "выйти", когда внутри
        {
            return pages.Internal.IsOnThisPage();
        }

        public bool IsNotLoginIn()
        //проверка поля телефон, когда находишься на странице авторизации
        {
            return pages.Login.IsOnThisPage();
        }
         public bool IsLoginOut()
        // проверка выхода, когда разлогинился и попал на лендинг
        {
            return pages.Lending.IsOnThisPage();
             //здесь нужен лендинг
        }

         public void LoginOut()
        // разлогин.
        {
           pages.Internal.LogoutLink.Click();
        }
        
    }
}