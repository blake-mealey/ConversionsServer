using ConversionsDb.Models.Units;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsDal.Entities.Units
{
    public class UnitTypeEntity
    {
        public UnitTypeEntity(UnitType unitType, Unit baseUnit, IEnumerable<Unit> units)
        {
            Id = unitType.Id;
            DisplayName = unitType.DisplayName;
            BaseUnit = new UnitEntity(baseUnit);
            Units = units.Select(u => new UnitEntity(u)).ToList();
        }

        public int Id;

        public string DisplayName;

        public UnitEntity BaseUnit;

        public List<UnitEntity> Units;
    }
}
