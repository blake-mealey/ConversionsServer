using ConversionsDb.Models.Units;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConversionsDb
{
    public class ConversionsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            System.Diagnostics.Debugger.Launch();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Conversions"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new UnitTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UnitTypeMapConfiguration());
            modelBuilder.ApplyConfiguration(new BaseUnitMapConfiguration());
            modelBuilder.ApplyConfiguration(new RelativeValueConfiguration());
        }

        #region Units
        public DbSet<Unit> Units { get; set; }

        public DbSet<UnitType> UnitTypes { get; set; }

        public DbSet<UnitTypeMap> UnitTypeMaps { get; set; }

        public DbSet<BaseUnitMap> BaseUnitMaps { get; set; }

        public DbSet<RelativeValue> RelativeValues { get; set; }
        #endregion
    }
}
