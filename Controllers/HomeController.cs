using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using personaal.Models;

namespace personaal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();
        public IActionResult MusicPlayer() => View();
        public IActionResult OurStory() => View();
        public IActionResult Level1() => View();
        public IActionResult Game() => View();
        public IActionResult Secret() => View();
        public IActionResult Forever() => View();
    }
}
