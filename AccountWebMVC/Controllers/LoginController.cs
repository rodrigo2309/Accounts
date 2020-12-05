using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountWebMVC.Models;
using AccountWebMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace AccountWebMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login2()
        {
            return View();
        }
        public IActionResult Logar(Usuarios usuarios) 
        {
            if (usuarios.Nome == null)
            {
                return View(nameof(Login2));
            }
            if (usuarios.Senha == null)
            {
                return View(nameof(Login2));
            }

            if (_loginService.confereSenha(usuarios.Nome, usuarios.Senha))
            {
                return RedirectToAction(nameof(Index),"Releases");
            }

            ViewData["Resultado"] = "Deu ruim";

            return RedirectToAction(nameof(Login2));

            
        }
    }
}
