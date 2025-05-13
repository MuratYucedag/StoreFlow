using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents
{
    public class _NavbarDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
