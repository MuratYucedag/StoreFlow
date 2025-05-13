using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents
{
    public class _RightSidebarDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
