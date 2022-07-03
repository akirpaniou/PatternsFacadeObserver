using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Observer.Department;
using Observer.Models;
using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Observer.Controllers
{
    public class HomeController : Controller
    {
        /*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        private readonly IAsset _testers;
        private readonly IDotnet _dotnet;
        private readonly IResignation _resignation;
        public HomeController(IAsset testers, IDotnet dotnet, IResignation resignation, ILibrary library)
        {
            _testers = testers;
            _dotnet = dotnet;
            _resignation = resignation;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TestersDept()
        {
            _testers.AllocateAsset();
            ViewBag.Dept = "Testers - Allocated assets";
            return View("Index");
        }

        [HttpPost]
        public IActionResult Dotnet()
        {
            _dotnet.CalculateSalary();
            ViewBag.Dept = "Dotnet - Calculated salary";
            return View("Index");
        }

        [HttpPost]
        public void EmployeeSeparate(string EmployeeId)
        {
            _resignation.NotifyObserver(EmployeeId);
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
