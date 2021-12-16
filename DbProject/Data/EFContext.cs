using DbProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbProject.Data
{
    public class EFContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Saleitem> Saleitems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite(@"Data Source=c:\Dbsql\MyDb.db;");
        }
    }
}
