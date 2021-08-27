using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Training_Csharp
{
    public partial class Modul_Struct_BaseContext : DbContext
    {
        public Modul_Struct_BaseContext()
        {
        }

        public Modul_Struct_BaseContext(DbContextOptions<Modul_Struct_BaseContext> options)
            : base(options)
        {

        }

        public virtual DbSet<ModulStructBasis> ModulStructBases { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ModulStructBasis>(entity =>
            {
                entity.ToTable("Modul_Struct_Bases");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
