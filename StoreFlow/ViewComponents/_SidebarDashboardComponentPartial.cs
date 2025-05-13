using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents
{
    public class _SidebarDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
