using ConversionsDb.Models.Units;

namespace ConversionsDal.Entities.Units
{
    public class UnitEntity
    {
        public UnitEntity(Unit unit)
        {
            Id = unit.Id;
            DisplayName = unit.DisplayName;
            Symbol = unit.Symbol;
        }

        public int Id;

        public string DisplayName;

        public string Symbol;
    }
}
