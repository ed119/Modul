using OpenQA.Selenium.Remote;
using System;
using NUnit.Framework;
using Newtonsoft.Json;



namespace Modul
{

    [TestFixture()]

    public class Base
    {

       protected Application app;

            [SetUp]
            public void StartApplication()
            {
                app = new Application(DesiredCapabilities.Chrome(), "https://low.modulbank.ru/login", null);
            }
           
        }
    }

    
    
    
    
    
    
    
    
    
    
   

     

        