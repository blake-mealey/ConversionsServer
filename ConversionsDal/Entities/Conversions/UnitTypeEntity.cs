using Chimerical.Conversions.Db.Models.Conversions;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Dal.Entities.Conversions
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
