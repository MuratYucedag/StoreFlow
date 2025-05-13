using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents
{
    public class _FooterDashboardComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
