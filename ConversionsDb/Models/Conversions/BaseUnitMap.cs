using ConversionsDb.SeedData;
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
                new { UnitTypeId = UnitTypeData.Distance.Id, BaseUnitSymbol = UnitData.Metre.Symbol });
        }
    }
}
