using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Units
{
    [Table("RelativeValue", Schema = "Units")]
    public class RelativeValue
    {
        [Key]
        [Column(Order = 1)]
        public int BaseUnitId { get; set; }

        [ForeignKey("BaseUnitId")]
        public Unit BaseUnit { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UnitId { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }

        [Required]
        public double Value { get; set; }
    }
}
