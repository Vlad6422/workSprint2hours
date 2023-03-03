using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppl
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<TimeDb> Times { get; set; }
        public ApplicationContext()
        {
            Database.EnsureDeleted(); //For 1st create. Then Delete this.
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TestBd;Trusted_Connection=True;");
        }
    }
}
