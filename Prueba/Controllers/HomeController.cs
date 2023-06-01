using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Configuration;
using Prueba.Models;
using Prueba.Models.dbModels;
using Prueba.ViewModel;
using System.Diagnostics;

namespace Prueba.Controllers
{
    
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly LBooks20Context _context;

        public HomeController(ILogger<HomeController> logger, LBooks20Context context)
        {
            _logger = logger;
            _context = context;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                Libros = _context.Libros.ToList()
            };
            return View(hvm);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contactanos()
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