using ConversionsDb.Models.Units;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsDal.Entities.Units
{
    public class UnitEntity
    {
        public UnitEntity()
        {
        }

        public UnitEntity(Unit unit, IEnumerable<RelativeValue> relativeValues)
        {
            Id = unit.Id;
            DisplayName = unit.DisplayName;
            Symbol = unit.Symbol;

            RelativeValues = relativeValues.Select(x => new RelativeValueEntity(x)).ToList();
        }

        public int Id;

        public string DisplayName;

        public string Symbol;

        public List<RelativeValueEntity> RelativeValues;
    }
}
