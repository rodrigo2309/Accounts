using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountWebMVC.Controllers
{
    public class ReleasesController : Controller
    {
        public IActionResult Index()
        {
            List<Release> list = new List<Release>();
            list.Add(new Release { Id = 1, Local = "Mundial"});
            list.Add(new Release { Id = 2, Local = "Farmácia"});
            list.Add(new Release { Id = 3, Local = "teste" });

            return View(list);
        }
    }
}
