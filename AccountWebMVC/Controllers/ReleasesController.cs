using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AccountWebMVC.Services;
using AccountWebMVC.Models;
using AccountWebMVC.Models.ViewModels;
using System.Net;


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

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _releasesService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            //List<Release> release = _releasesService.FindAll();
            //ReleasesFormViewModel viewModel = new ReleasesFormViewModel {Local = obj, Release = obj };
            return View(obj);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _releasesService.FindById(id.Value);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        
        public IActionResult Create()
        {
            var local = _localService.FindAll();
            var viewModel = new ReleasesFormViewModel { Local = local }; 
            return View(viewModel); //new Release()
        } 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Release release)
        {
            _releasesService.Insert(release);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _releasesService.Remove(id);
            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Release release)
        {
            _releasesService.Update(release);
            return RedirectToAction(nameof(Index));
        }
    }
}
