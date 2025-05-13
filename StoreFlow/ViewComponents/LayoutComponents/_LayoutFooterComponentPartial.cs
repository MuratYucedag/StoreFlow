using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.ViewComponents.LayoutComponents
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
