using ConversionsDb.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Units
{
    [Table("Conversion", Schema = "Units")]
    public class Conversion
    {
        [Key]
        [Column(Order = 1)]
        public int FromUnitId { get; set; }

        [ForeignKey("FromUnitId")]
        public virtual Unit FromUnit { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ToUnitId { get; set; }

        [ForeignKey("ToUnitId")]
        public virtual Unit ToUnit { get; set; }

        [Required]
        public double Multiplier { get; set; }
    }

    public class RelativeValueConfiguration : IEntityTypeConfiguration<Conversion>
    {
        public void Configure(EntityTypeBuilder<Conversion> builder)
        {
            builder.HasKey(u => new
            {
                FromUnitIt = u.FromUnitId,
                u.ToUnitId
            });

            builder.HasData(ConversionData.DistanceConversions.ToArray());
        }
    }
}
