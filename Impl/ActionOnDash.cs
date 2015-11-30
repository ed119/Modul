

namespace Tooktodo
{
    class ActionOnDash : BaseModul
    {
        public ActionOnDash(PagesCollection pages) : base(pages)
        {
        }

        public void CreateNewProject()
        {
            pages.Dash.CreateNewProjectElement.Click();
        }
    }
}
