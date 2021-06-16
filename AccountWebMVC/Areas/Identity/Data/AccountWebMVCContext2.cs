using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountWebMVC.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccountWebMVC.Data
{
    public class AccountWebMVCContext2 : IdentityDbContext<AccountWebMVCUser>
    {
        public AccountWebMVCContext2(DbContextOptions<AccountWebMVCContext2> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<AccountWebMVC.Models.Release> Release { get; set; }

        public DbSet<AccountWebMVC.Models.Local> Local { get; set; }

        public DbSet<AccountWebMVC.Models.Tipo> Tipo { get; set; }

        public DbSet<AccountWebMVC.Models.Usuarios> Usuarios { get; set; }
    }
}
