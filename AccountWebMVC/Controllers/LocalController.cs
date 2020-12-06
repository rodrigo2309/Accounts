using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountWebMVC.Models;
using AccountWebMVC.Models.ViewModels;
using AccountWebMVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccountWebMVC.Controllers
{
    public class LocalController : Controller
    {
        private readonly LocalService _localService;

        private readonly TipoService _tipoService;

        public LocalController(LocalService localService,TipoService tipoService)
        {
            _localService = localService;
            _tipoService = tipoService;
        }
        [Authorize]
        public IActionResult Index()
        {
            var list = _localService.FindAll();
            return View(list);
        }
        [Authorize]
        public IActionResult Create()
        {
            var tipo = _tipoService.FindAll();
            var viewModel = new LocalFormViewModel { Tipo = tipo };
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Local local)
        {
            _localService.Insert(local);
            return RedirectToAction("Index","Releases");
        }
    }
}
