using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Libros()
        {
            return View();
        }

        public IActionResult Logins()
        {
            return View();
        }
    }
}
