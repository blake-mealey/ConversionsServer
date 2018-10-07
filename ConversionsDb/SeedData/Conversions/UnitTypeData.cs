using ConversionsDb.Models.Conversions;
using System.Collections.Generic;

namespace ConversionsDb.SeedData.Conversions
{
    public static class UnitTypeData
    {
        public static readonly UnitType Area = new UnitType
        {
            Id = 1,
            DisplayName = "Area"
        };

        public static readonly UnitType DigitalStorage = new UnitType
        {
            Id = 3,
            DisplayName = "Digital Storage"
        };

        public static readonly UnitType Distance = new UnitType
        {
            Id = 4,
            DisplayName = "Distance"
        };

        public static readonly UnitType Energy = new UnitType
        {
            Id = 5,
            DisplayName = "Energy"
        };

        public static readonly UnitType Frequency = new UnitType
        {
            Id = 6,
            DisplayName = "Frequency"
        };

        public static readonly UnitType FuelEconomy = new UnitType
        {
            Id = 7,
            DisplayName = "Fuel Economy"
        };

        public static readonly UnitType Mass = new UnitType
        {
            Id = 8,
            DisplayName = "Mass"
        };

        public static readonly UnitType PlaneAngle = new UnitType
        {
            Id = 9,
            DisplayName = "Plane Angle"
        };

        public static readonly UnitType Pressure = new UnitType
        {
            Id = 10,
            DisplayName = "Pressure"
        };

        public static readonly UnitType Speed = new UnitType
        {
            Id = 11,
            DisplayName = "Speed"
        };

        //        public static readonly UnitType Temperature = new UnitType
        //        {
        //            Id = 12,
        //            DisplayName = "Temperature"
        //        };

        public static readonly UnitType Time = new UnitType
        {
            Id = 13,
            DisplayName = "Time"
        };

        public static readonly UnitType Volume = new UnitType
        {
            Id = 14,
            DisplayName = "Volume"
        };

        public static readonly List<UnitType> UnitTypes = new List<UnitType>
        {
            Area,
            DigitalStorage,
            Distance,
            Energy,
            Frequency,
            FuelEconomy,
            Mass,
            PlaneAngle,
            Pressure,
            Speed,
//            Temperature,
            Time,
            Volume
        };
    }
}
