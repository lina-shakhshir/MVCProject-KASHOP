using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCProject.Data;
using MVCProject.Models;

namespace MVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
    ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            //var product = context.Products.ToList();
            //ViewData["categories"] = context.Products.ToList();
            ViewBag.CategoryId = new SelectList(context.Categories, "Id", "Name");
            return View();
        }

        public IActionResult Store( Product request, IFormFile Image)
        {
            return Content("ok");
        }
        
    }
}
