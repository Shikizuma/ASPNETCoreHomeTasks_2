using ASPNETCoreHomeTasks_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNETCoreHomeTasks_2.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DownloadLessonDescription()
        {
            var pathToFile = Path.Combine("Views", "Home", "Index.cshtml");
            var mimeType = "text/html";
            var fileContents = System.IO.File.ReadAllBytes(pathToFile);
            return File(fileContents, mimeType, "Index.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}