using Chimerical.Conversions.Db.Models.Conversions;

namespace Chimerical.Conversions.Dal.Entities.Conversions
{
    public class UnitEntity
    {
        public UnitEntity(Unit unit)
        {
            Symbol = unit.Symbol;
            DisplayName = unit.DisplayName;
        }

        public string Symbol;

        public string DisplayName;
    }
}
