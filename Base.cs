using OpenQA.Selenium.Remote;
using System;
using NUnit.Framework;
using Newtonsoft.Json;



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
                return "http://account.beat24.igsystems.ru/";
            }
        }

       protected Application app;

            [SetUp]
            public void StartApplication()
            {
                
                app = new Application(DesiredCapabilities.Chrome(), Url, null);
                //меняем логику, для возможности использовать разные точки входа
                //app = new Application(DesiredCapabilities.Chrome(), "https://low.modulbank.ru/login", null);
            }
           
        }
    }

    
    
    
    
    
    
    
    
    
    
   

     

        