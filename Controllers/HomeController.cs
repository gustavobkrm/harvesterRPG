using harvesterRPG.Models;
using harvesterRPG.Services;
using harvesterRPG.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace harvesterRPG.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetItemsFromDices(string dices, string climate)
        {
            List<JobItem> resultado = _homeService.teste(dices, climate);

            return Json(resultado);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
