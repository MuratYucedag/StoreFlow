using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents
{
    public class _HeadDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
