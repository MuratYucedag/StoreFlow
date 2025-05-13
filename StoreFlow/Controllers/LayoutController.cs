using Microsoft.AspNetCore.Mvc;

namespace StoreFlow.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
