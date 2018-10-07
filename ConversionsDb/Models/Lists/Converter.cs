using Chimerical.Conversions.Db.Models.Conversions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chimerical.Conversions.Db.Models.Lists
{
    [Table("Converter", Schema = "Lists")]
    public class Converter
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int UnitTypeId { get; set; }

        [ForeignKey("UnitTypeId")]
        public virtual UnitType UnitType { get; set; }
    }
}
