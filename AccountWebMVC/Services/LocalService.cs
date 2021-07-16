using System.Collections.Generic;
using System.Linq;
using AccountWebMVC.Data;
using AccountWebMVC.Models;

namespace AccountWebMVC.Services
{
    public class LocalService
    {
        private readonly AccountWebMVCContext _context;

        public LocalService(AccountWebMVCContext context)
        {
            _context = context;
        }

        public List<Local> FindAll(string idUsuario)
        {
            return _context.Local.Where(i => i.LoginID == idUsuario).ToList() ; //.OrderBy(x => x.Nome)
        }

        public void Insert(Local obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
