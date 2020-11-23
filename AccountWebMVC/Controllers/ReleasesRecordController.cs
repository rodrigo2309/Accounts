using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AccountWebMVC.Controllers
{
    public class ReleasesRecordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReleaseSearch()
        {
            return View();
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }

    }
}