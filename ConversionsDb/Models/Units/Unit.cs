using ConversionsDb.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Units
{
    [Table("Unit", Schema = "Units")]
    public class Unit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(64)]
        public string DisplayName { get; set; }

        [Required]
        [MaxLength(8)]
        public string Symbol { get; set; }
    }

    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasData(UnitData.LengthUnits.ToArray());
        }
    }
}
