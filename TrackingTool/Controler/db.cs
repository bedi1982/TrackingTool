using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using TrackingTool6.Model;

namespace TrackingTool6.db
{
    class TrackingToolEntities : DbContext
    {
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor");
            modelBuilder.Entity<Loja>().ToTable("Lojas");
            modelBuilder.Entity<CentroDeCusto>().ToTable("CentrosDeCusto");
            modelBuilder.Entity<ContaReceber>().ToTable("ContaReceber");
            modelBuilder.Entity<ContaAPagar>().ToTable("ContaAPagar");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Fornecedor> Fornecedores { set; get; }
        public DbSet<Loja> Lojas { set; get; }
        public DbSet<CentroDeCusto> CentrosDeCusto { set; get; }
        public DbSet<ContaReceber> ContaReceber { set; get; }
        public DbSet<ContaAPagar> ContaAPagar { set; get; }
    }
}