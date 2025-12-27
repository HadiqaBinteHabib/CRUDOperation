using CRUDOperation.Data;
using CRUDOperation.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDOperation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly EFCoreDbContext _context;

        public CategoryController(EFCoreDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> list = _context.Categories.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {

            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
