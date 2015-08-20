using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Modul
{
    public class RegDataCompany : AnyPage
    {
        public RegDataCompany(PagesCollection pageManager)
            : base(pageManager)
        { }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[2]/div/div[2]/div/a")]
        public IWebElement RefSetOgrnLater;


        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[2]/div/div[1]/form/div[1]/div/input")]
        public IWebElement OgrnInputReg;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[2]/div/div[1]/form/div[1]/button")]
        public IWebElement BtnFindConpanyReg;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[2]/div/div[4]/div/div[2]/button")]
        public IWebElement BtnItsMyCo;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[2]/div/div[4]/div/div[2]/div/span[2]")] 
        public IWebElement LinkItsNotMyCo;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[2]/div/div[4]/div/div[2]/div/span[2]")]
        public IWebElement LinkWrongDataKompany;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div/section[2]/div[2]/div/div[5]/div/a")]
        public IWebElement LinkReturnToMain;

        
        
        
        
        //assert calltous page
        public bool IsOnThisPage()
        {
            return IsElementPresent(By.XPath("html/body/div[1]/div/div/div/section[2]/div[2]/div/div[5]/div/a"));
        }






    }
}
