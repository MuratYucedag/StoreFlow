using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents.LayoutComponents
{
    public class _LayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
