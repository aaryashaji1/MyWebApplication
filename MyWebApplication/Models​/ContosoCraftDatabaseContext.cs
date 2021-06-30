using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyWebApplication.Models​
{
    public partial class ContosoCraftDatabaseContext : DbContext
    {
        public ContosoCraftDatabaseContext()
        {
        }

        public ContosoCraftDatabaseContext(DbContextOptions<ContosoCraftDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=ARYASHAJI\\SQLEXPRESS;Initial Catalog=ContosoCraftDatabase;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Id).IsRequired();

                entity.Property(e => e.Img).IsRequired();

                entity.Property(e => e.Maker).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.Url).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
