using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents
{
    public class _ScriptsDashboardComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
