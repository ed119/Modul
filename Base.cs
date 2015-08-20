using OpenQA.Selenium.Remote;
using System;
using NUnit.Framework;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Modul
{
    public class BaseWithStaff : Base
    {
        protected override string Url

            //заменяем точку входа (override - переписать)
            //тесты будут группироваться по родителям
        {
            get
            {
                return "http://beat24.igsystems.ru/login/staff/";
            }

        }

    }



    [TestFixture()]
    public class Base
    {
       

        protected virtual string Url
        {
            get
            {
                return "https://accountlow.modulbank.ru/";
            }
        }

       protected Application app;
       

            [SetUp]

            public void StartApplication()
       {
          
           
                app = new Application(DesiredCapabilities.Firefox(), Url, null);
                
                
                //меняем логику, для возможности использовать разные точки входа
                //app = new Application(DesiredCapabilities.Chrome(), "https://accountlow.modulbank.ru/login", null);
            }
           
        }
    }

    
    
    
    
    
    
    
    
    
    
   

     

        