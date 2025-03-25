using Microsoft.EntityFrameworkCore;
using T5_PR1.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace T5_PR1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Simulacio> Simulacions { get; set; }
        public DbSet<ConsumAigua> ConsumsAigua { get; set; }
        public DbSet<IndicadorEnergetic> IndicadorsEnergetics { get; set; }

        //Constructor necessari per injecció de dependencies
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        
    }
}
