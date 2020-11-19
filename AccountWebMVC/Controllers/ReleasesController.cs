using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AccountWebMVC.Services;
using AccountWebMVC.Models;
using AccountWebMVC.Models.ViewModels;
using System.Linq;


namespace AccountWebMVC.Controllers
{
    public class ReleasesController : Controller
    {
        private readonly ReleasesService _releasesService;

        private readonly LocalService _localService;

        public ReleasesController(ReleasesService releasesService,LocalService localService)
        {
            _releasesService = releasesService;
            _localService = localService;
        }
        
        public IActionResult Index()
        {
            var list = _releasesService.FindAll();
            return View(list);
        }
        
        public IActionResult Create()
        {
            return View();
            /*
            var local = _localService.FindAll();
            var viewModel = new ReleasesFormViewModel { Local = local }; 
            return View(viewModel); //new Release()
            */
        } 


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Release release)
        {
            return View();
            /*
            _releasesService.Insert(release);
            return RedirectToAction(nameof(Index));
            */
        }
        

    }
}
