using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AccountWebMVC.Services;
using AccountWebMVC.Models;
using AccountWebMVC.Models.ViewModels;
using System.Net;
using Microsoft.AspNetCore.Authorization;

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
        //[Authorize]
        public IActionResult Index()
        {
            var list = _releasesService.FindAll();
            return View(list);
        }
        //[Authorize]
        public IActionResult Details(int? id)
        {
            var list = _releasesService.FindById(id.Value);
            return View(list);
        }
        //[Authorize]
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

            List<Local> local = _localService.FindAll();
            ReleasesFormViewModel viewModel = new ReleasesFormViewModel {Local = local, Release = obj };
            return View(viewModel);

        }
        //[Authorize]
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
        //[Authorize]
        public IActionResult Create()
        {
            var local = _localService.FindAll();
            var viewModel = new ReleasesFormViewModel { Local = local }; 
            return View(viewModel); //new Release()
        }
        //[Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Release release)
        {
            _releasesService.Insert(release);
            return RedirectToAction(nameof(Index));
        }
        //[Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _releasesService.Remove(id);
            return RedirectToAction(nameof(Index));

        }
        //[Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Release release)
        {
            _releasesService.Update(release);
            return RedirectToAction(nameof(Index));
        }
    }
}
