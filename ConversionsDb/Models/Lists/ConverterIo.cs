using ConversionsDb.Models.Conversions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Lists
{
    [Table("ConverterIo", Schema = "Lists")]
    public class ConverterIo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int ConverterIoTypeId { get; set; }

        [ForeignKey("ConverterIoTypeId")]
        public ConverterIoType ConverterIoType { get; set; }

        [Required]
        public Guid ConverterId { get; set; }

        [ForeignKey("ConverterId")]
        public virtual Converter Converter { get; set; }

        [Required]
        public string UnitSymbol { get; set; }

        [ForeignKey("UnitSymbol")]
        public virtual Unit Unit { get; set; }

        public double Value { get; set; }
    }
}
