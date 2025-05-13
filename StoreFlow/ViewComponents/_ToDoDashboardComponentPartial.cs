using Microsoft.AspNetCore.Mvc;
using StoreFlow.Context;

namespace StoreFlow.ViewComponents
{
    public class _ToDoDashboardComponentPartial:ViewComponent
    {
        private readonly StoreContext _context;
        public _ToDoDashboardComponentPartial(StoreContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Todos.OrderByDescending(x => x.TodoId).Take(6).ToList();
            return View(values);
        }
    }
}
