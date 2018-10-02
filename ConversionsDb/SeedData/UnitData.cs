using ConversionsDb.Models.Conversions;
using System.Collections.Generic;

namespace ConversionsDb.SeedData
{
    public static class UnitData
    {
        #region Area units
        public static readonly Unit SquareKilometre = new Unit
        {
            Symbol = "km²",
            DisplayName = "Square Kilometre"
        };

        public static readonly Unit SquareMetre = new Unit
        {
            Symbol = "m²",
            DisplayName = "Square Metre"
        };

        public static readonly Unit SquareMile = new Unit
        {
            Symbol = "mi²",
            DisplayName = "Square Mile"
        };

        public static readonly Unit SquareYard = new Unit
        {
            Symbol = "yd²",
            DisplayName = "Square Yard"
        };

        public static readonly Unit SquareFoot = new Unit
        {
            Symbol = "ft²",
            DisplayName = "Square Foot"
        };

        public static readonly Unit SquareInch = new Unit
        {
            Symbol = "in²",
            DisplayName = "Square Inch"
        };

        public static readonly Unit Hectare = new Unit
        {
            Symbol = "ha",
            DisplayName = "Hectare"
        };

        public static readonly Unit Acre = new Unit
        {
            Symbol = "ac",
            DisplayName = "Acre"
        };

        public static readonly List<Unit> AreaUnits = new List<Unit>
        {
            SquareKilometre,
            SquareMetre,
            SquareMile,
            SquareYard,
            SquareFoot,
            SquareInch,
            Hectare,
            Acre
        };
        #endregion

        #region Distance units
        public static readonly Unit Kilometre = new Unit
        {
            Symbol = "km",
            DisplayName = "Kilometre"
        };

        public static readonly Unit Metre = new Unit
        {
            Symbol = "m",
            DisplayName = "Metre"
        };

        public static readonly Unit Decimetre = new Unit
        {
            Symbol = "dm",
            DisplayName = "Decimetre"
        };

        public static readonly Unit Centimetre = new Unit
        {
            Symbol = "cm",
            DisplayName = "Centimetre"
        };

        public static readonly Unit Millimetre = new Unit
        {
            Symbol = "mm",
            DisplayName = "Millimetre"
        };

        public static readonly Unit Micrometre = new Unit
        {
            Symbol = "μm",
            DisplayName = "Micrometre"
        };

        public static readonly Unit Nanometre = new Unit
        {
            Symbol = "nm",
            DisplayName = "Nanometre"
        };

        public static readonly Unit Mile = new Unit
        {
            Symbol = "mi",
            DisplayName = "Mile"
        };

        public static readonly Unit Yard = new Unit
        {
            Symbol = "yd",
            DisplayName = "Yard"
        };

        public static readonly Unit Foot = new Unit
        {
            Symbol = "ft",
            DisplayName = "Foot"
        };

        public static readonly Unit Inch = new Unit
        {
            Symbol = "in",
            DisplayName = "Inch"
        };

        public static readonly Unit NauticalMile = new Unit
        {
            Symbol = "nmi",
            DisplayName = "Nautical Mile"
        };

        public static readonly List<Unit> DistanceUnits = new List<Unit>
        {
            Kilometre,
            Metre,
            Decimetre,
            Centimetre,
            Millimetre,
            Micrometre,
            Nanometre,
            Mile,
            Yard,
            Foot,
            Inch,
            NauticalMile
        };
        #endregion
    }
}
