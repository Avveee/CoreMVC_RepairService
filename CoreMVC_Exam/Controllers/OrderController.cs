using CoreMVC_Exam.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC_Exam.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationContext _context;

        public OrderController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Orders()
        {
            return View();
        }

        public ActionResult CreateOrder()
        {
            return View();
        }

        public ActionResult EditOrder(string id)
        {
            var order = (from o in _context.Orders
                         where o.id == id
                         select o).FirstOrDefault();

            if (order == null)
                return RedirectToAction("Orders", "Home");

            return View("EditOrder", order);
        }
    }
}
