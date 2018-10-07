using Chimerical.Conversions.Db.SeedData.Conversions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chimerical.Conversions.Db.Models.Conversions
{
    [Table("Unit", Schema = "Conversions")]
    public class Unit
    {
        [Key]
        [MaxLength(8)]
        public string Symbol { get; set; }

        [Required]
        [MaxLength(64)]
        public string DisplayName { get; set; }
    }

    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasData(UnitData.AreaUnits.ToArray());
            builder.HasData(UnitData.DigitalStorageUnits.ToArray());
            builder.HasData(UnitData.DistanceUnits.ToArray());
            builder.HasData(UnitData.EnergyUnits.ToArray());
            builder.HasData(UnitData.FrequencyUnits.ToArray());
            builder.HasData(UnitData.FuelEconomyUnits.ToArray());
            builder.HasData(UnitData.MassUnits.ToArray());
            builder.HasData(UnitData.PlaneAngleUnits.ToArray());
            builder.HasData(UnitData.PressureUnits.ToArray());
            builder.HasData(UnitData.SpeedUnits.ToArray());
            //            builder.HasData(UnitData.TemperatureUnits.ToArray());
            builder.HasData(UnitData.TimeUnits.ToArray());
            builder.HasData(UnitData.VolumeUnits.ToArray());
        }
    }
}
