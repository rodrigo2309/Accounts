using AccountWebMVC.Data;
using AccountWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace AccountWebMVC.Services
{
    public class TipoService
    {
        private readonly AccountWebMVCContext _context;

        public TipoService(AccountWebMVCContext context)
        {
            _context = context;
        }

        public List<Tipo> FindAll()
        {
            return _context.Tipo.ToList();
        }

    }
}
