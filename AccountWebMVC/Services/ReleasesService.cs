using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountWebMVC.Data;
using AccountWebMVC.Models;
using AccountWebMVC.Services.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AccountWebMVC.Services
{
    public class ReleasesService
    {        
        private readonly AccountWebMVCContext _context;

        public ReleasesService(AccountWebMVCContext context)
        {
            _context = context;
        }
        

        public void Seed()
        {
            if (_context.Release.Any())
            {
                return;
            }

            Tipo t1 = new Tipo(1, "MERCADO");
            Tipo t2 = new Tipo(2, "FARMÀCIA");

            Local l1 = new Local(1,"MUNDIAL",t1,"");
            Local l2 = new Local(2, "PACHECO", t2,"");

            Release d1 = new Release(1,l1, 100, DateTime.Now,"teste");
            Release d2 = new Release(2,l2, 200, DateTime.Now,"teste");

            _context.Release.AddRange(d1, d2);

            _context.SaveChanges();

        }

        public List<Release> FindAll(string idUsuario)
        {
            return _context.Release.Include(obj => obj.Local).Where(i => i.LoginId == idUsuario).ToList();
        }

        public void Insert(Release obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Release FindById(int id)
        {
            return _context.Release.Include(obj => obj.Local).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Release.Find(id);
            _context.Release.Remove(obj);
            _context.SaveChanges();
        }
        
        public void Update(Release obj)
        {
            if (!_context.Release.Any(x => x.Id == obj.Id))
            {
                throw new DllNotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }


        }
    }
}
