using CoreMVC_Exam.Data;
using CoreMVC_Exam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CoreMVC_Exam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Categories()
        {
            return View();
        }

        public ActionResult CreateCategory()
        {
            return View();
        }

        public ActionResult EditCategory(string id)
        {
            var cat = (from c in _context.Categories
                       where c.id == id
                       select c).FirstOrDefault();

            if (cat == null)
                return RedirectToAction("Categories", "Home");

            return View("EditCategory", cat);
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

        public IActionResult Products()
        {
            return View();
        }

        public ActionResult CreateProduct()
        {
            return View();
        }

        public ActionResult EditProduct(string id)
        {
            var product = (from p in _context.Products
                       where p.id == id
                       select p).FirstOrDefault();

            if (product == null)
                return RedirectToAction("Products", "Home");

            return View("EditProduct", product);
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}