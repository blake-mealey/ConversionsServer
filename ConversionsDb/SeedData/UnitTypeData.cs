using ConversionsDb.Models.Units;
using System.Collections.Generic;

namespace ConversionsDb.SeedData
{
    public static class UnitTypeData
    {
        public static readonly UnitType Distance = new UnitType
        {
            Id = 1,
            DisplayName = "Distance"
        };

        private static readonly List<UnitType> UnitTypes = new List<UnitType>
        {
            Distance
        };
    }
}
