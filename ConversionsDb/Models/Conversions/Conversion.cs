using ConversionsDb.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Conversions
{
    [Table("Conversion", Schema = "Conversions")]
    public class Conversion
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(8)]
        public string FromUnitSymbol { get; set; }

        [ForeignKey("FromUnitSymbol")]
        public virtual Unit FromUnit { get; set; }

        [Key]
        [Column(Order = 2)]
        [MaxLength(8)]
        public string ToUnitSymbol { get; set; }

        [ForeignKey("ToUnitSymbol")]
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
                u.FromUnitSymbol,
                u.ToUnitSymbol
            });

            builder.HasData(ConversionData.AreaConversions.ToArray());
            builder.HasData(ConversionData.DistanceConversions.ToArray());
        }
    }
}
