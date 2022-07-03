using AuthenticationCopm;
using AuthorizationComp;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ValidationComp;
using WebLogin.Models;

namespace WebLogin.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        /*
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */

        public IActionResult Index()
        {
            return View();
        }

        /*
        //http
        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            var validation = new ValidationSer();
            if (validation.IsValitdated(email, password))
            {
                var authentication = new AuthSer();
                if (authentication.IsAuthenticated(email, password))
                {
                    var authorization = new AuthorSer();
                    if (authorization.IsAuthorized(email, password))
                    {
                        return RedirectToAction("Home");
                    }
                }
            }
            return Index();
        }
        */
        private readonly ILoginFacade _loginFacade;
        public HomeController(ILoginFacade loginFacade)
        {
            _loginFacade = loginFacade;
        }
        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            if(_loginFacade.CanLogin(email, password))
            {
                return RedirectToAction("Home");
            }
            return Index();
        }


        public IActionResult Home()
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
