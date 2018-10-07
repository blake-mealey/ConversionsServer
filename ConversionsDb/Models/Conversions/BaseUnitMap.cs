using ConversionsDb.SeedData.Conversions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Conversions
{
    [Table("BaseUnitMap", Schema = "Conversions")]
    public class BaseUnitMap
    {
        [Key]
        [Column(Order = 1)]
        public int UnitTypeId { get; set; }

        [ForeignKey("UnitTypeId")]
        public virtual UnitType UnitType { get; set; }

        [MaxLength(8)]
        public string BaseUnitSymbol { get; set; }

        [ForeignKey("BaseUnitSymbol")]
        public virtual Unit BaseUnit { get; set; }
    }

    public class BaseUnitMapConfiguration : IEntityTypeConfiguration<BaseUnitMap>
    {
        public void Configure(EntityTypeBuilder<BaseUnitMap> builder)
        {
            builder.HasData(
                new { UnitTypeId = UnitTypeData.Area.Id, BaseUnitSymbol = UnitData.SquareKilometre.Symbol },
                new { UnitTypeId = UnitTypeData.DigitalStorage.Id, BaseUnitSymbol = UnitData.Byte.Symbol },
                new { UnitTypeId = UnitTypeData.Distance.Id, BaseUnitSymbol = UnitData.Metre.Symbol },
                new { UnitTypeId = UnitTypeData.Energy.Id, BaseUnitSymbol = UnitData.Joule.Symbol },
                new { UnitTypeId = UnitTypeData.Frequency.Id, BaseUnitSymbol = UnitData.Hertz.Symbol },
                new { UnitTypeId = UnitTypeData.FuelEconomy.Id, BaseUnitSymbol = UnitData.KilometrePerLitre.Symbol },
                new { UnitTypeId = UnitTypeData.Mass.Id, BaseUnitSymbol = UnitData.Kilogram.Symbol },
                new { UnitTypeId = UnitTypeData.PlaneAngle.Id, BaseUnitSymbol = UnitData.Degree.Symbol },
                new { UnitTypeId = UnitTypeData.Pressure.Id, BaseUnitSymbol = UnitData.Pascal.Symbol },
                new { UnitTypeId = UnitTypeData.Speed.Id, BaseUnitSymbol = UnitData.MetrePerSecond.Symbol },
                //                new { UnitTypeId = UnitTypeData.Temperature.Id, BaseUnitSymbol = UnitData.Celsius.Symbol },
                new { UnitTypeId = UnitTypeData.Time.Id, BaseUnitSymbol = UnitData.Second.Symbol },
                new { UnitTypeId = UnitTypeData.Volume.Id, BaseUnitSymbol = UnitData.Litre.Symbol });
        }
    }
}
