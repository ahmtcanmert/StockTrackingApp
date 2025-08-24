using Microsoft.EntityFrameworkCore;
using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StokTakip.DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<InventoryItem> InventoryItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source = CAN\AHMETCANPC; Database = StockDb; Integrated Security = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Soft delete filter
            modelBuilder.Entity<InventoryItem>().HasQueryFilter(p => !p.IsDeleted);
        }

    }
}

