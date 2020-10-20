using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountWebMVC.Data;
using AccountWebMVC.Models;

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

            Release d1 = new Release(1, 1, 1, 1,DateTime.Now);
            Release d2 = new Release(2, 2, 2, 2,DateTime.Now);

            _context.Release.AddRange(d1, d2);

            _context.SaveChanges();

        }

        public List<Release> FindAll()
        {
            return _context.Release.ToList();
        }

        public void Insert(Release obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        
    }
}
