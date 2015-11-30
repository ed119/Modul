using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tooktodo
{
    public class DashboardPage : AnyPage
    {
        public DashboardPage(PagesCollection pageManager) : base(pageManager)
        {
        }

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[1]/header/div[1]/div/div[3]/div/div[1]")] 
        public IWebElement DropDownElement;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[1]/header/div[1]/div/div[3]/div/div[2]/div[2]/div")] 
        public IWebElement ExitDropdownElement;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[2]/div/div[1]/div/div[1]/div[1]/div/div/a")] 
        public IWebElement CreateNewProjectElement;

        //filling form
        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/form/div[1]/div[1]/div/input")] 
        public IWebElement NameProjectField;

        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/form/div[5]/div[1]/div/input")] 
        public IWebElement PhoneField;

        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/form/div[7]/div[2]/div[1]/div/div/div/span")] 
        public IWebElement RegionField;

        [FindsBy(How = How.XPath,
            Using = "html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/form/div[7]/div[3]/div[1]/input")] 
        public IWebElement CityField;

        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div[2]/div/div/div[2]/div/div[1]/form/div[8]/input")] 
        public IWebElement CreateProjButton;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ui-select-choices-row-1-0']/a")]
        public IWebElement RegionName;


    }
}
