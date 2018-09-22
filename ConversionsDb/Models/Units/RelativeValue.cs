using ConversionsDb.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Units
{
    [Table("RelativeValue", Schema = "Units")]
    public class RelativeValue
    {
        [Key]
        [Column(Order = 1)]
        public int BaseUnitId { get; set; }

        [ForeignKey("BaseUnitId")]
        public Unit BaseUnit { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UnitId { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }

        [Required]
        public double Value { get; set; }
    }

    public class RelativeValueConfiguration : IEntityTypeConfiguration<RelativeValue>
    {
        public void Configure(EntityTypeBuilder<RelativeValue> builder)
        {
            builder.HasKey(u => new
            {
                u.BaseUnitId,
                u.UnitId
            });

            builder.HasData(RelativeValueData.DistanceRelativeValues.ToArray());
        }
    }
}
