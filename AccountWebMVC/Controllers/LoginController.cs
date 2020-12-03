using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Logar(string usrname, string psw) 
        {
            if (usrname == null)
            {
                return NotFound();
            }
            if (psw == null)
            {
                return NotFound();
            }

            if (_loginService.confereSenha(usrname, psw))
            {
                return RedirectToAction(nameof(Index),"Releases");
            }

            return NotFound();

            
        }
    }
}
