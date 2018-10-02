using ConversionsDb.Models.Conversions;
using System.Collections.Generic;

namespace ConversionsDb.SeedData
{
    public static class UnitTypeData
    {
        public static readonly UnitType Area = new UnitType
        {
            Id = 2,
            DisplayName = "Area"
        };

        public static readonly UnitType Distance = new UnitType
        {
            Id = 1,
            DisplayName = "Distance"
        };

        private static readonly List<UnitType> UnitTypes = new List<UnitType>
        {
            Area, Distance
        };
    }
}
