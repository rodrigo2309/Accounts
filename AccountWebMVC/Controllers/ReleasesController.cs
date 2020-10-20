using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AccountWebMVC.Services;
using AccountWebMVC.Models;

namespace AccountWebMVC.Controllers
{
    public class ReleasesController : Controller
    {
        private readonly ReleasesService _releasesService;

        public ReleasesController(ReleasesService releasesService)
        {            
            _releasesService = releasesService;
        }

        public IActionResult Index()
        {
            var list = _releasesService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View(new Release());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Release release)
        {
            _releasesService.Insert(release);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
