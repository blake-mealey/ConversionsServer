using ConversionsDb.Models.Conversions;

namespace ConversionsDal.Entities.Conversions
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
