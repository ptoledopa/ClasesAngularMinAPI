using System;
using System.Collections.Generic;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanArchitecture.Infraestructure.Data.Context
{
    public partial class BDEmpresaContext : DbContext
    {
        public BDEmpresaContext()
        {
        }

        public BDEmpresaContext(DbContextOptions<BDEmpresaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("data source = LAPTOP-BN0C1K6G;initial catalog = BDEmpresa;Trusted_Connection=Yes;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
