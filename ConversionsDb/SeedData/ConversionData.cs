using ConversionsDb.Models.Conversions;
using System.Collections.Generic;

namespace ConversionsDb.SeedData
{
    public static class ConversionData
    {
        #region Area Conversions
        private static readonly Conversion SquareKilometreToHectare = new Conversion
        {
            FromUnitSymbol = UnitData.SquareKilometre.Symbol,
            ToUnitSymbol = UnitData.Hectare.Symbol,
            Multiplier = 100.0
        };

        private static readonly Conversion SquareKilometreToSquareMetre = new Conversion
        {
            FromUnitSymbol = UnitData.SquareKilometre.Symbol,
            ToUnitSymbol = UnitData.SquareMetre.Symbol,
            Multiplier = 10000000.0
        };

        private static readonly Conversion SquareMileToSquareKilometre = new Conversion
        {
            FromUnitSymbol = UnitData.SquareMile.Symbol,
            ToUnitSymbol = UnitData.SquareKilometre.Symbol,
            Multiplier = 2.58999
        };

        private static readonly Conversion SquareMileToAcre = new Conversion
        {
            FromUnitSymbol = UnitData.SquareMile.Symbol,
            ToUnitSymbol = UnitData.Acre.Symbol,
            Multiplier = 640.0
        };

        private static readonly Conversion SquareMileToSquareYard = new Conversion
        {
            FromUnitSymbol = UnitData.SquareMile.Symbol,
            ToUnitSymbol = UnitData.SquareYard.Symbol,
            Multiplier = 3097600.0
        };

        private static readonly Conversion SquareMileToSquareFoot = new Conversion
        {
            FromUnitSymbol = UnitData.SquareMile.Symbol,
            ToUnitSymbol = UnitData.SquareFoot.Symbol,
            Multiplier = 27878400.0
        };

        private static readonly Conversion SquareMileToSquareInch = new Conversion
        {
            FromUnitSymbol = UnitData.SquareMile.Symbol,
            ToUnitSymbol = UnitData.SquareInch.Symbol,
            Multiplier = 4014489600.0
        };

        public static readonly List<Conversion> AreaConversions = new List<Conversion>
        {
            SquareKilometreToHectare,
            SquareKilometreToSquareMetre,
            SquareMileToSquareKilometre,
            SquareMileToAcre,
            SquareMileToSquareYard,
            SquareMileToSquareFoot,
            SquareMileToSquareInch
        };
        #endregion

        #region Distance Conversion
        private static readonly Conversion KilometreToMetre = new Conversion
        {
            FromUnitSymbol = UnitData.Kilometre.Symbol,
            ToUnitSymbol = UnitData.Metre.Symbol,
            Multiplier = 1000.0
        };

        private static readonly Conversion MetreToDecimetre = new Conversion
        {
            FromUnitSymbol = UnitData.Metre.Symbol,
            ToUnitSymbol = UnitData.Decimetre.Symbol,
            Multiplier = 10.0
        };

        private static readonly Conversion MetreToCentimetre = new Conversion
        {
            FromUnitSymbol = UnitData.Metre.Symbol,
            ToUnitSymbol = UnitData.Centimetre.Symbol,
            Multiplier = 100.0
        };

        private static readonly Conversion MetreToMillimetre = new Conversion
        {
            FromUnitSymbol = UnitData.Metre.Symbol,
            ToUnitSymbol = UnitData.Millimetre.Symbol,
            Multiplier = 1000.0
        };

        private static readonly Conversion MetreToMicrometre = new Conversion
        {
            FromUnitSymbol = UnitData.Metre.Symbol,
            ToUnitSymbol = UnitData.Micrometre.Symbol,
            Multiplier = 1000000.0
        };

        private static readonly Conversion MetreToNanometre = new Conversion
        {
            FromUnitSymbol = UnitData.Metre.Symbol,
            ToUnitSymbol = UnitData.Nanometre.Symbol,
            Multiplier = 1000000000.0
        };

        private static readonly Conversion FootToMetre = new Conversion
        {
            FromUnitSymbol = UnitData.Foot.Symbol,
            ToUnitSymbol = UnitData.Metre.Symbol,
            Multiplier = 0.3048
        };

        private static readonly Conversion MileToFoot = new Conversion
        {
            FromUnitSymbol = UnitData.Mile.Symbol,
            ToUnitSymbol = UnitData.Foot.Symbol,
            Multiplier = 5280.0
        };

        private static readonly Conversion YardToFoot = new Conversion
        {
            FromUnitSymbol = UnitData.Yard.Symbol,
            ToUnitSymbol = UnitData.Foot.Symbol,
            Multiplier = 3.0
        };

        private static readonly Conversion FootToInch = new Conversion
        {
            FromUnitSymbol = UnitData.Foot.Symbol,
            ToUnitSymbol = UnitData.Inch.Symbol,
            Multiplier = 12.0
        };

        private static readonly Conversion NauticalMileToFoot = new Conversion
        {
            FromUnitSymbol = UnitData.NauticalMile.Symbol,
            ToUnitSymbol = UnitData.Foot.Symbol,
            Multiplier = 6076.12
        };

        public static readonly List<Conversion> DistanceConversions = new List<Conversion>
        {
            KilometreToMetre,
            MetreToDecimetre,
            MetreToCentimetre,
            MetreToMillimetre,
            MetreToMicrometre,
            MetreToNanometre,
            FootToMetre,
            MileToFoot,
            YardToFoot,
            FootToInch,
            NauticalMileToFoot
        };
        #endregion
    }
}
