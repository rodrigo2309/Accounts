using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AccountWebMVC.Models.ViewModels;
using AccountWebMVC.Services;

namespace AccountWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ReleasesService _releasesService;

        public HomeController(ReleasesService releasesService)
        {
            _releasesService = releasesService;
        }

        public IActionResult Index()
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
