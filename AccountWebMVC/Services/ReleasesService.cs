using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountWebMVC.Data;
using AccountWebMVC.Models;
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

            Local l1 = new Local(1,"MUNDIAL",t1);
            Local l2 = new Local(2, "PACHECO", t2);

            Release d1 = new Release(1,l1, 100, DateTime.Now);
            Release d2 = new Release(2,l2, 200, DateTime.Now);

            _context.Release.AddRange(d1, d2);

            _context.SaveChanges();

        }

        public List<Release> FindAll()
        {
            return _context.Release.Include(obj => obj.Local).ToList();
        }

        public void Insert(Release obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        
    }
}
