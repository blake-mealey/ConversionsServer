using Chimerical.Conversions.Db.SeedData.Lists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chimerical.Conversions.Db.Models.Lists
{
    [Table("ConverterIoType", Schema = "Lists")]
    public class ConverterIoType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(8)]
        public string Name { get; set; }
    }

    public class ConverterIoTypeConfiguration : IEntityTypeConfiguration<ConverterIoType>
    {
        public void Configure(EntityTypeBuilder<ConverterIoType> builder)
        {
            builder.HasData(ConverterIoTypeData.ConverterIoTypes.ToArray());
        }
    }
}
