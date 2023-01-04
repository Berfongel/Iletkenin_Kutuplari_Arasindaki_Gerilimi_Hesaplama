using GerilimHesabiWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GerilimHesabiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(GerilimHesabi gerilimHesabi)
        {
            var akim_ = gerilimHesabi.Akim;
            var direnc_ = gerilimHesabi.Direnc;
            var gerilim_ = akim_ * direnc_;

            ViewBag.Message = "Gerilim(V) Değeri : " + gerilim_;

            return View("gerilimHesabi");
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