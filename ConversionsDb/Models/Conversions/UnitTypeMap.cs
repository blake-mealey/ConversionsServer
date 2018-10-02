using ConversionsDb.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Conversions
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

            AddMaps(UnitTypeData.Distance, UnitData.DistanceUnits);
            AddMaps(UnitTypeData.Area, UnitData.AreaUnits);
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
