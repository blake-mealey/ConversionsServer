using ConversionsDb.SeedData.Conversions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Conversions
{
    [Table("UnitType", Schema = "Conversions")]
    public class UnitType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string DisplayName { get; set; }
    }

    public class UnitTypeConfiguration : IEntityTypeConfiguration<UnitType>
    {
        public void Configure(EntityTypeBuilder<UnitType> builder)
        {
            builder.HasData(UnitTypeData.UnitTypes.ToArray());
        }
    }
}
