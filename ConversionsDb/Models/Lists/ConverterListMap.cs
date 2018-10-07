using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chimerical.Conversions.Db.Models.Lists
{
    [Table("ConverterListMap", Schema = "Lists")]
    public class ConverterListMap
    {
        [Key]
        [Column(Order = 1)]
        public Guid ConverterListId { get; set; }

        [ForeignKey("ConverterListId")]
        public ConverterList ConverterList { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ConverterId { get; set; }

        [ForeignKey("ConverterId")]
        public Converter Converter { get; set; }
    }

    public class ConverterListMapConfiguration : IEntityTypeConfiguration<ConverterListMap>
    {
        public void Configure(EntityTypeBuilder<ConverterListMap> builder)
        {
            builder.HasKey(u => new
            {
                u.ConverterListId,
                u.ConverterId
            });
        }
    }
}
