using ConversionsDb.Models.Units;
using System.Collections.Generic;

namespace ConversionsDb.SeedData
{
    public static class ConversionData
    {
        #region Distance Values
        private static readonly Conversion KilometreToMetre = new Conversion
        {
            FromUnitId = UnitData.Kilometre.Id,
            ToUnitId = UnitData.Metre.Id,
            Multiplier = 1000.0
        };

        private static readonly Conversion DecimetreToMetre = new Conversion
        {
            FromUnitId = UnitData.Decimetre.Id,
            ToUnitId = UnitData.Metre.Id,
            Multiplier = 0.1
        };

        private static readonly Conversion CentimetreToMetre = new Conversion
        {
            FromUnitId = UnitData.Centimetre.Id,
            ToUnitId = UnitData.Metre.Id,
            Multiplier = 0.01
        };

        private static readonly Conversion MillimetreToMetre = new Conversion
        {
            FromUnitId = UnitData.Millimetre.Id,
            ToUnitId = UnitData.Metre.Id,
            Multiplier = 0.001
        };

        private static readonly Conversion MicrometreToMetre = new Conversion
        {
            FromUnitId = UnitData.Micrometre.Id,
            ToUnitId = UnitData.Metre.Id,
            Multiplier = 0.000001
        };

        private static readonly Conversion NanometreToMetre = new Conversion
        {
            FromUnitId = UnitData.Nanometre.Id,
            ToUnitId = UnitData.Metre.Id,
            Multiplier = 0.000000001
        };

        private static readonly Conversion FootToMetre = new Conversion
        {
            FromUnitId = UnitData.Foot.Id,
            ToUnitId = UnitData.Metre.Id,
            Multiplier = 0.3048
        };

        private static readonly Conversion MileToFoot = new Conversion
        {
            FromUnitId = UnitData.Mile.Id,
            ToUnitId = UnitData.Foot.Id,
            Multiplier = 5280.0
        };

        private static readonly Conversion YardToFoot = new Conversion
        {
            FromUnitId = UnitData.Yard.Id,
            ToUnitId = UnitData.Foot.Id,
            Multiplier = 3.0
        };

        private static readonly Conversion FootToInch = new Conversion
        {
            FromUnitId = UnitData.Foot.Id,
            ToUnitId = UnitData.Inch.Id,
            Multiplier = 12.0
        };

        private static readonly Conversion NauticalMileToFoot = new Conversion
        {
            FromUnitId = UnitData.NauticalMile.Id,
            ToUnitId = UnitData.Foot.Id,
            Multiplier = 6076.12
        };

        public static readonly List<Conversion> DistanceConversions = new List<Conversion>
        {
            KilometreToMetre,
            DecimetreToMetre,
            CentimetreToMetre,
            MillimetreToMetre,
            MicrometreToMetre,
            NanometreToMetre,
            FootToMetre,
            MileToFoot,
            YardToFoot,
            FootToInch,
            NauticalMileToFoot
        };
        #endregion
    }
}
