﻿using OpenQA.Selenium.Remote;
using System;
using NUnit.Framework;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;


namespace Tooktodo
{
    

    [TestFixture()]
    public class Base
    {
       

        protected virtual string Url
        {
            get
            {
                return "http://tooktodo.igstest.ru/login";
            }
        }

       
       protected Application app;
        
       

            [SetUp]

            public void StartApplication()
       {
          
           
                app = new Application(DesiredCapabilities.Firefox(), Url, null);
                



       }
           
        }
}

    
    
    
    
    
    
    
    
    
    
   

     

        