    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountWebMVC.Models;

namespace AccountWebMVC.Data
{
    public class AccountWebMVCContext : DbContext
    {
        public AccountWebMVCContext (DbContextOptions<AccountWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AccountWebMVC.Models.Release> Release { get; set; }

        public DbSet<AccountWebMVC.Models.Local> Local { get; set; }

        public DbSet<AccountWebMVC.Models.Tipo> Tipo { get; set; }

        public DbSet<AccountWebMVC.Models.Usuarios> Usuarios { get; set; }
    }
}
