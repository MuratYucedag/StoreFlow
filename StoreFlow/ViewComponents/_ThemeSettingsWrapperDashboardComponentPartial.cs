using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents
{
    public class _ThemeSettingsWrapperDashboardComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
