using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents
{
    public class _ChartDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
