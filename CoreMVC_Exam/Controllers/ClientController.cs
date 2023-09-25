using CoreMVC_Exam.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC_Exam.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationContext _context;

        public ClientController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Clients()
        {
            return View();
        }

        public ActionResult CreateClient()
        {
            return View();
        }

        public ActionResult EditClient(string id)
        {
            var client = (from c in _context.Clients
                          where c.passport_id == id
                          select c).FirstOrDefault();

            if (client == null)
                return RedirectToAction("Clients", "Home");

            return View("EditClient", client);
        }
    }
}
