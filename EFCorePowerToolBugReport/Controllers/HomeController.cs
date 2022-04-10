using EFCorePowerToolBugReport.Data;
using EFCorePowerToolBugReport.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EFCorePowerToolBugReport.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContosouniversityContext db;

        public HomeController(ILogger<HomeController> logger, ContosouniversityContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return Ok(db.Department.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}