using ConversionsDb.Models.Units;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsDal.Entities.Units
{
    public class UnitTypeEntity
    {
        public UnitTypeEntity(UnitType unitType, UnitEntity baseUnit, IEnumerable<UnitEntity> units)
        {
            Id = unitType.Id;
            DisplayName = unitType.DisplayName;
            BaseUnit = baseUnit;
            Units = units.ToList();
        }

        public int Id;

        public string DisplayName;

        public UnitEntity BaseUnit;

        public List<UnitEntity> Units;
    }
}
