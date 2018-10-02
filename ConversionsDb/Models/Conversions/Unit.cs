using ConversionsDb.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Conversions
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
            builder.HasData(UnitData.DistanceUnits.ToArray());
        }
    }
}
