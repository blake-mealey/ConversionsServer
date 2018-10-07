using Chimerical.Conversions.Db.SeedData.Conversions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chimerical.Conversions.Db.Models.Conversions
{
    [Table("UnitTypeMap", Schema = "Conversions")]
    public class UnitTypeMap
    {
        [Key]
        [Column(Order = 1)]
        public int UnitTypeId { get; set; }

        [ForeignKey("UnitTypeId")]
        public virtual UnitType UnitType { get; set; }

        [Key]
        [Column(Order = 2)]
        [MaxLength(8)]
        public string UnitSymbol { get; set; }

        [ForeignKey("UnitSymbol")]
        public virtual Unit Unit { get; set; }
    }

    public class UnitTypeMapConfiguration : IEntityTypeConfiguration<UnitTypeMap>
    {
        private EntityTypeBuilder<UnitTypeMap> _builder;

        public void Configure(EntityTypeBuilder<UnitTypeMap> builder)
        {
            _builder = builder;

            _builder.HasKey(u => new
            {
                u.UnitTypeId,
                u.UnitSymbol
            });

            AddMaps(UnitTypeData.Area, UnitData.AreaUnits);
            AddMaps(UnitTypeData.DigitalStorage, UnitData.DigitalStorageUnits);
            AddMaps(UnitTypeData.Distance, UnitData.DistanceUnits);
            AddMaps(UnitTypeData.Energy, UnitData.EnergyUnits);
            AddMaps(UnitTypeData.Frequency, UnitData.FrequencyUnits);
            AddMaps(UnitTypeData.FuelEconomy, UnitData.FuelEconomyUnits);
            AddMaps(UnitTypeData.Mass, UnitData.MassUnits);
            AddMaps(UnitTypeData.PlaneAngle, UnitData.PlaneAngleUnits);
            AddMaps(UnitTypeData.Pressure, UnitData.PressureUnits);
            AddMaps(UnitTypeData.Speed, UnitData.SpeedUnits);
            //            AddMaps(UnitTypeData.Temperature, UnitData.TemperatureUnits);
            AddMaps(UnitTypeData.Time, UnitData.TimeUnits);
            AddMaps(UnitTypeData.Volume, UnitData.VolumeUnits);
        }

        private void AddMaps(UnitType type, IEnumerable<Unit> units)
        {
            foreach (var unit in units)
            {
                _builder.HasData(new { UnitTypeId = type.Id, UnitSymbol = unit.Symbol });
            }
        }
    }
}
