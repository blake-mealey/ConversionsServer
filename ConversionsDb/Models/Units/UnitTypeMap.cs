using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConversionsDb.Models.Units
{
    [Table("UnitTypeMap", Schema = "Units")]
    public class UnitTypeMap
    {
        [Key]
        [Column(Order = 1)]
        public int UnitTypeId { get; set; }

        [ForeignKey("UnitTypeId")]
        public UnitType UnitType { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UnitId { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }
    }
}
