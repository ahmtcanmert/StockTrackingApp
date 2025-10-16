using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StokTakip.Entities;
using System.IO;
using Microsoft.Extensions.Configuration.Json;
namespace StokTakip.DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<InventoryLog> InventoryLogs { get; set; }  

     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source = .; Database = StockDb; Integrated Security = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Soft delete filter
            modelBuilder.Entity<InventoryItem>().HasQueryFilter(p => !p.IsDeleted);
        }

        

    }
}
