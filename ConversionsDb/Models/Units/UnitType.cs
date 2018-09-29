using ConversionsDb.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Units
{
    [Table("UnitType", Schema = "Units")]
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
            builder.HasData(UnitTypeData.Area, UnitTypeData.Distance);
        }
    }
}
