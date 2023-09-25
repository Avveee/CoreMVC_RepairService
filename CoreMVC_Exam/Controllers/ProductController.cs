using CoreMVC_Exam.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreMVC_Exam.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationContext _context;

        public ProductController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Products()
        {
            return View();
        }

        public ActionResult CreateProduct()
        {
            ViewData["category_id"] = new SelectList(_context.Categories, "id", "name");
            return View();
        }

        public ActionResult EditProduct(string id)
        {
            var product = (from p in _context.Products
                           where p.id == id
                           select p).FirstOrDefault();

            if (product == null)
                return RedirectToAction("Products", "Home");
            ViewData["category_id"] = new SelectList(_context.Categories, "id", "name");
            return View("EditProduct", product);
        }
    }
}
