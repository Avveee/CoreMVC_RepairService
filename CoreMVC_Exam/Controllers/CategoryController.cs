using CoreMVC_Exam.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC_Exam.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationContext _context;

        public CategoryController(ApplicationContext context)
        {
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
    }
}
