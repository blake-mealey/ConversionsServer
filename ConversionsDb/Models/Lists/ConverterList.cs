using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chimerical.Conversions.Db.Models.Lists
{
    [Table("ConverterList", Schema = "Lists")]
    public class ConverterList
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(64)]
        public string DisplayName { get; set; }
    }
}
