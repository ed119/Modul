using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tooktodo
{
    public class MailPage : AnyPage 
    {
        
        
        public MailPage(PagesCollection pageManager)
            : base(pageManager)
        {
            
        }


        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement LoginElement;


        [FindsBy(How = How.Name, Using = "passwd")] 
        public IWebElement PasswordElement;

        [FindsBy(How = How.XPath, Using = "//div[@class='new-left']//button[.='Войти']")] 
        public IWebElement EnterButton;

        [FindsBy(How = How.XPath,
            Using =
                "html/body/div[2]/div/div[5]/div/div[3]/div/div[3]/div/div/div/div/div[3]/div/div/div[3]/div[2]/div[1]/span[2]/span/a/span[1]/span/span[1]"
            )] public IWebElement MyLetterElement;

        [FindsBy(How = How.CssSelector, Using = ".daria-goto-anchor")] 
        public IWebElement BeginWorkButton;

    }
}
