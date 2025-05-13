using Microsoft.AspNetCore.Mvc;
using StoreFlow.Context;

namespace StoreFlow.ViewComponents.RightSidebarComponents
{
    public class _RightSidebarToDoListComponentPartial:ViewComponent
    {
        private readonly StoreContext _context;
        public _RightSidebarToDoListComponentPartial(StoreContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Todos.OrderBy(x=>x.TodoId).ToList().TakeLast(15).ToList();
            return View(values);
        }
    }
}
