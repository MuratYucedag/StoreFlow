using Microsoft.AspNetCore.Mvc;
using StoreFlow.Context;

namespace StoreFlow.ViewComponents.LayoutComponents
{
    public class _LayoutMessageOnNavbarComponentPartial : ViewComponent
    {
        private readonly StoreContext _context;
        public _LayoutMessageOnNavbarComponentPartial(StoreContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Messages.Where(y => y.IsRead == false).OrderByDescending(x => x.MessageId).Take(3).ToList();
            ViewBag.messageCount = _context.Messages.Where(x => x.IsRead == false).Count();
            return View(values);
        }
    }
}
