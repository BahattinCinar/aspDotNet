using aspDotNet.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspDotNet.DataAccsessLayer.Concrate
{
    public class Context : IdentityDbContext<appUser, appRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BAHATTIN\\SQLEXPRESS;initial catalog=AspDotNetDb;integrated Security=true;TrustServerCertificate=True");
        }

        public DbSet<CustommerAccount> CustommerAccounts { get; set; }

        public DbSet<CustommerAccountProcess> CustommerAccountsProcess { get; set; }
    }
}
