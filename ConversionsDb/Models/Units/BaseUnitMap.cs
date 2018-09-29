using ConversionsDb.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Units
{
    [Table("BaseUnitMap", Schema = "Units")]
    public class BaseUnitMap
    {
        [Key]
        [Column(Order = 1)]
        public int UnitTypeId { get; set; }

        [ForeignKey("UnitTypeId")]
        public virtual UnitType UnitType { get; set; }

        [Key]
        [Column(Order = 2)]
        public int BaseUnitId { get; set; }

        [ForeignKey("BaseUnitId")]
        public virtual Unit BaseUnit { get; set; }
    }

    public class BaseUnitMapConfiguration : IEntityTypeConfiguration<BaseUnitMap>
    {
        public void Configure(EntityTypeBuilder<BaseUnitMap> builder)
        {
            builder.HasKey(u => new
            {
                u.UnitTypeId,
                u.BaseUnitId
            });

            builder.HasData(
                new { UnitTypeId = UnitTypeData.Area.Id, BaseUnitId = UnitData.SquareKilometre.Id },
                new { UnitTypeId = UnitTypeData.Distance.Id, BaseUnitId = UnitData.Metre.Id });
        }
    }
}
