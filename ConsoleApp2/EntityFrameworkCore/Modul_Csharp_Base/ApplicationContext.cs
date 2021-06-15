using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Training_Csharp.EntityFrameworkCore.Modul_Csharp_Base
{
    class ApplicationContext : DbContext
    {
        public DbSet<Modul_Struct_Base> Modul_Struct_Bases { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Modul_Struct_Base;Trusted_Connection=True;");
        }
    }
}
