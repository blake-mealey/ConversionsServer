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
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Conversions"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Units
            modelBuilder.Entity<UnitTypeMap>().HasKey(u => new
            {
                u.UnitTypeId,
                u.UnitId
            });

            modelBuilder.Entity<BaseUnitMap>().HasKey(u => new
            {
                u.UnitTypeId,
                u.UnitId
            });

            modelBuilder.Entity<RelativeValue>().HasKey(u => new
            {
                u.BaseUnitId,
                u.UnitId
            });
            #endregion
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
