using System.Diagnostics;
using HavenClubAndResort.Models;
using Microsoft.AspNetCore.Mvc;

namespace HavenClubAndResort.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();


        }
             public IActionResult AboutUs()
        {
            return View();
        }
       
        public IActionResult Membership()
        {
            return View();
        }
        public IActionResult Memberships()
        {
            return View();
        }
        public IActionResult TravelBlog()
        {
            return View();
        }
        public IActionResult ContatUs()
        {
            return View();
        }
        public IActionResult PrivacyAndPolicy()
        {
            return View();
        }
        public IActionResult North()
        {
            return View();
        }
        public IActionResult termsCondition()
        {
            return View();
        } 
        public IActionResult PayAndPolicy()
        {
            return View();
        }
        public IActionResult Destination()
        {
            return View();
        }
        public IActionResult NorthZone()
        {
            return View();
        }
        public IActionResult SouthZone()
        {
            return View();
        }
        public IActionResult AsiaZone()
        {
            return View();
        }
        public IActionResult EuropeZone()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult MemberLogin()
        {
            return View();
        }
        public IActionResult NewIndexPage()
        {
            return View();
        }
    }
}
