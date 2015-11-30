

namespace Tooktodo
{
    public class ActionOnDash : BaseModul
    {
        public ActionOnDash(PagesCollection pages) : base(pages)
        {
        }

        public void CreateNewProject()
        {
            pages.Dash.CreateNewProjectElement.Click();
        }

        public void FillingFormProject()
        {
            pages.Dash.NameProjectField.Clear();
            pages.Dash.NameProjectField.SendKeys("Новое имя проекта");
            pages.Dash.PhoneField.SendKeys("1233332211");
            pages.Dash.RegionField.Click();
            pages.Dash.RegionName.Click();
            //pages.Dash.RegionField.SendKeys(Enter);
            pages.Dash.CityField.SendKeys("Казань");


        }
    }
}
