using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountWebMVC.Models;
using AccountWebMVC.Services;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous] //coloca metodo publico 
        public ActionResult Login(string returnURL)
        {
            ViewBag.ReturnURL = returnURL;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login,string returnURL)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var achou = (login.Usuario == "ranieresilva" && login.Senha == "123") ;

            if (achou)
            {
                //FormsAuthentication.SetAuthCookie(login.Usuario, login.LembrarMe);
                if (Url.IsLocalUrl(returnURL))
                {
                    return Redirect(returnURL);
                }
                else
                {
                    RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Login inválido.");
            }

            return View(login);
        }

        public IActionResult Logar(Usuarios usuarios) 
        {
            if (usuarios.Nome == null)
            {
                return View(nameof(Login));
            }
            if (usuarios.Senha == null)
            {
                return View(nameof(Login));
            }

            if (_loginService.confereSenha(usuarios.Nome, usuarios.Senha))
            {
                return RedirectToAction(nameof(Index),"Releases");
            }

            ViewData["Resultado"] = "Deu ruim";

            return RedirectToAction(nameof(Login));

            
        }
    }
}
