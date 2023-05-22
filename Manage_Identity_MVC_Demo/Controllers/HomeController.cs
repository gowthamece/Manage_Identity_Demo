using Manage_Identity_MVC_Demo.Models;
using Manage_Identity_MVC_Demo.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Manage_Identity_MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            await ManageBlob.UploadBlob("mysawebappmi", "mycontainer", "DemoFile", "Hello World");
            return View();
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