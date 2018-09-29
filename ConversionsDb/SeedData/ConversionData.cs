﻿using ConversionsDb.Models.Units;
using System.Collections.Generic;

namespace ConversionsDb.SeedData
{
    public static class ConversionData
    {
        #region Area Conversions
        private static readonly Conversion SquareKilometreToHectare = new Conversion
        {
            FromUnitId = UnitData.SquareKilometre.Id,
            ToUnitId = UnitData.Hectare.Id,
            Multiplier = 100.0
        };

        private static readonly Conversion SquareKilometreToSquareMetre = new Conversion
        {
            FromUnitId = UnitData.SquareKilometre.Id,
            ToUnitId = UnitData.SquareMetre.Id,
            Multiplier = 10000000.0
        };

        private static readonly Conversion SquareMileToSquareKilometre = new Conversion
        {
            FromUnitId = UnitData.SquareMile.Id,
            ToUnitId = UnitData.SquareKilometre.Id,
            Multiplier = 2.58999
        };

        private static readonly Conversion SquareMileToAcre = new Conversion
        {
            FromUnitId = UnitData.SquareMile.Id,
            ToUnitId = UnitData.Acre.Id,
            Multiplier = 640.0
        };

        private static readonly Conversion SquareMileToSquareYard = new Conversion
        {
            FromUnitId = UnitData.SquareMile.Id,
            ToUnitId = UnitData.SquareYard.Id,
            Multiplier = 3097600.0
        };

        private static readonly Conversion SquareMileToSquareFoot = new Conversion
        {
            FromUnitId = UnitData.SquareMile.Id,
            ToUnitId = UnitData.SquareFoot.Id,
            Multiplier = 27878400.0
        };

        private static readonly Conversion SquareMileToSquareInch = new Conversion
        {
            FromUnitId = UnitData.SquareMile.Id,
            ToUnitId = UnitData.SquareInch.Id,
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
            FromUnitId = UnitData.Kilometre.Id,
            ToUnitId = UnitData.Metre.Id,
            Multiplier = 1000.0
        };

        private static readonly Conversion MetreToDecimetre = new Conversion
        {
            FromUnitId = UnitData.Metre.Id,
            ToUnitId = UnitData.Decimetre.Id,
            Multiplier = 10.0
        };

        private static readonly Conversion MetreToCentimetre = new Conversion
        {
            FromUnitId = UnitData.Metre.Id,
            ToUnitId = UnitData.Centimetre.Id,
            Multiplier = 100.0
        };

        private static readonly Conversion MetreToMillimetre = new Conversion
        {
            FromUnitId = UnitData.Metre.Id,
            ToUnitId = UnitData.Millimetre.Id,
            Multiplier = 1000.0
        };

        private static readonly Conversion MetreToMicrometre = new Conversion
        {
            FromUnitId = UnitData.Metre.Id,
            ToUnitId = UnitData.Micrometre.Id,
            Multiplier = 1000000.0
        };

        private static readonly Conversion MetreToNanometre = new Conversion
        {
            FromUnitId = UnitData.Metre.Id,
            ToUnitId = UnitData.Nanometre.Id,
            Multiplier = 1000000000.0
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