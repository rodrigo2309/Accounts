using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var list = _localService.FindAll(userId);
            return View(list);
        }
        [Authorize]
        public IActionResult Create()
        {
            var tipo = _tipoService.FindAll();
            var viewModel = new LocalFormViewModel { Tipo = tipo };
            return View(viewModel);
        }
        public IActionResult TesteModal()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Local local)
        {
            local.LoginID = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            _localService.Insert(local);
            return RedirectToAction("Index","Releases");
        }
    }
}
