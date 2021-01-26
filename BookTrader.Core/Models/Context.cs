using FileContextCore;
using FileContextCore.FileManager;
using FileContextCore.Serializer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTrader.Core.Models
{
    public class Context : DbContext
    {
        public DbSet<SampleCompany> SampleCompanies { get; set; }
        public DbSet<SampleOrder> SampleOrders { get; set; }
        public DbSet<SampleOrderDetail> SampleOrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseFileContextDatabase<XMLSerializer, DefaultFileManager>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SampleCompany>().ToTable("SampleCompany");
            modelBuilder.Entity<SampleOrder>().ToTable("SampleOrder");
            modelBuilder.Entity<SampleOrderDetail>().ToTable("SampleOrderDetail");
        }
    }
}
