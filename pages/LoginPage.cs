﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class LoginPage : AnyPage
    {
        public LoginPage(PageManager pageManager)
            : base(pageManager)
        {
        }
        [FindsBy(How = How.Name, Using = "phone")]
        public IWebElement PhoneField;
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordField;
        [FindsBy(How = How.XPath, Using = "//div[@class='auth-bl']//button[.='Войти']")]
        public IWebElement GiveMeCode;
        [FindsBy(How = How.XPath, Using = "//div[@class='sms-bl__inner']/div/input")]
        public IWebElement SmsCode;
        [FindsBy(How = How.XPath, Using = "//div[@class='sms-bl__inner']//button[.='Подтвердить']")]
        public IWebElement SubmitButton;

        public bool IsOnThisPage()
        
            //проверка поля телефон, когда находишься на странице авторизации
        {
            return IsElementPresent(By.Name("phone"));
        }
        
    }
}