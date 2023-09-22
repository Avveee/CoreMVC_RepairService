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
                return RedirectToAction("Index", "Au");

            return View("EditCategory", cat);
        }

        public IActionResult Clients()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
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