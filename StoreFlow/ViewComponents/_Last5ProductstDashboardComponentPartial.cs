using Microsoft.AspNetCore.Mvc;
using StoreFlow.Context;

namespace StoreFlow.ViewComponents
{
    public class _Last5ProductstDashboardComponentPartial:ViewComponent
    {
        public StoreContext _context;
        public _Last5ProductstDashboardComponentPartial(StoreContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Products.OrderBy(x => x.ProductId).ToList().SkipLast(5).ToList().TakeLast(7).ToList();
            return View(values);
        }
    }
}
