using Chimerical.Conversions.Db.Models.Conversions;
using Chimerical.Conversions.Db.Models.Lists;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Chimerical.Conversions.Db.Models.Auth;

namespace Chimerical.Conversions.Db
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

            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseSqlServer(configuration.GetConnectionString("Conversions"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Units
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new UnitTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UnitTypeMapConfiguration());
            modelBuilder.ApplyConfiguration(new BaseUnitMapConfiguration());
            modelBuilder.ApplyConfiguration(new RelativeValueConfiguration());
            #endregion

            #region Lists
            modelBuilder.ApplyConfiguration(new ConverterListMapConfiguration());
            modelBuilder.ApplyConfiguration(new ConverterIoTypeConfiguration());
            #endregion
        }

        #region Auth
        public DbSet<IdentityProvider> IdentityProviders { get; set; }
        #endregion

        #region Units
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<UnitTypeMap> UnitTypeMaps { get; set; }
        public DbSet<BaseUnitMap> BaseUnitMaps { get; set; }
        public DbSet<Conversion> Conversions { get; set; }
        #endregion

        #region Lists
        public DbSet<Converter> Converters { get; set; }
        public DbSet<ConverterIo> ConverterIos { get; set; }
        public DbSet<ConverterIoType> ConverterIoTypes { get; set; }
        public DbSet<ConverterList> ConverterLists { get; set; }
        public DbSet<ConverterListMap> ConverterListMaps { get; set; }
        #endregion
    }
}
