using AccountWebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountWebMVC.Services
{
    public class LoginService
    {
        private readonly AccountWebMVCContext _context;
        public LoginService(AccountWebMVCContext context)
        {
            _context = context;
        }

        public bool confereSenha(string nome,string senha)
        {
            if (_context.Usuarios.FirstOrDefault(i => i.Nome == nome && i.Senha == senha) is null)
            {
                return false;
            }

            return (true);
        }

    }
}
