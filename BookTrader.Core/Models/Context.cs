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
        //public DbSet<SampleCompany> SampleCompanies { get; set; }
        //public DbSet<SampleOrder> SampleOrders { get; set; }
        //public DbSet<SampleOrderDetail> SampleOrderDetails { get; set; }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountStatistic> AccountStatistics { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<StockExchange> StockExchanges { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<TradeInstrument> TradeInstruments { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseFileContextDatabase<XMLSerializer, DefaultFileManager>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<AccountStatistic>().ToTable("AccountStatistic");
            modelBuilder.Entity<Operation>().ToTable("Operation");
            modelBuilder.Entity<StockExchange>().ToTable("StockExchange");
            modelBuilder.Entity<Tariff>().ToTable("Tariff");
            modelBuilder.Entity<TradeInstrument>().ToTable("TradeInstrument");
            modelBuilder.Entity<Transaction>().ToTable("Transaction");


            //modelBuilder.Entity<SampleCompany>().ToTable("SampleCompany");
            //modelBuilder.Entity<SampleOrder>().ToTable("SampleOrder");
            //modelBuilder.Entity<SampleOrderDetail>().ToTable("SampleOrderDetail");
        }
    }
}
