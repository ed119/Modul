﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class AuthModul : BaseModul

    {
              
        public AuthModul(PagesCollection pages): base(pages)
        {
            
        }

        public void LoginWithoutSms(AccountData account)
        {
            pages.Login.PhoneField.Clear();
            //поле телефона при фокусе не очищается
            pages.Login.PhoneField.SendKeys(account.phone);
            //pages.Login.PasswordField.Clear();
            //баг с очисткой поля пофиксили
            pages.Login.PasswordField.SendKeys(account.password);
            pages.Login.GiveMeCode.Click();
        }

        public void LoginWithSms(AccountData account)
        {
            pages.Login.PhoneField.Clear();
            pages.Login.PhoneField.SendKeys(account.phone);
            pages.Login.PasswordField.Clear();
            pages.Login.PasswordField.SendKeys(account.password);
            pages.Login.GiveMeCode.Click();
            pages.Login.SmsCode.SendKeys(account.smscode);
            pages.Login.SubmitButton.Click();
        }

        
        public bool IsLoginIn()
        // проверка элемента "выйти", когда внутри
        {
            return pages.DashBoard.IsOnThisPage();
        }

        public bool IsNotLoginIn()
        //проверка поля телефон, когда находишься на странице авторизации
        {
            return pages.Login.IsOnThisPage();
        }

        public bool IsNotLoginAlert()
        {
            return pages.Login.IsOnThisPageAlert();
            //по цсс селектору поле с валидахой, когда пароль не прошел
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
           pages.DashBoard.LogoutLink.Click();
        }
        
    }
}