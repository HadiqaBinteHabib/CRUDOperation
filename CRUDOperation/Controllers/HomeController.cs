using Microsoft.AspNetCore.Mvc;

namespace CRUDOperation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
