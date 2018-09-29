using ConversionsDb.Models.Units;
using System.Collections.Generic;

namespace ConversionsDb.SeedData
{
    public static class UnitData
    {
        #region Area units
        public static readonly Unit SquareKilometre = new Unit
        {
            Id = 13,
            DisplayName = "Square Kilometre",
            Symbol = "km²"
        };

        public static readonly Unit SquareMetre = new Unit
        {
            Id = 14,
            DisplayName = "Square Metre",
            Symbol = "m²"
        };

        public static readonly Unit SquareMile = new Unit
        {
            Id = 15,
            DisplayName = "Square Mile",
            Symbol = "mi²"
        };

        public static readonly Unit SquareYard = new Unit
        {
            Id = 16,
            DisplayName = "Square Yard",
            Symbol = "yd²"
        };

        public static readonly Unit SquareFoot = new Unit
        {
            Id = 17,
            DisplayName = "Square Foot",
            Symbol = "ft²"
        };

        public static readonly Unit SquareInch = new Unit
        {
            Id = 18,
            DisplayName = "Square Inch",
            Symbol = "in²"
        };

        public static readonly Unit Hectare = new Unit
        {
            Id = 19,
            DisplayName = "Square Hectare",
            Symbol = "ha"
        };

        public static readonly Unit Acre = new Unit
        {
            Id = 20,
            DisplayName = "Square Acre",
            Symbol = "ac"
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
            Id = 1,
            DisplayName = "Kilometre",
            Symbol = "km"
        };

        public static readonly Unit Metre = new Unit
        {
            Id = 2,
            DisplayName = "Metre",
            Symbol = "m"
        };

        public static readonly Unit Decimetre = new Unit
        {
            Id = 3,
            DisplayName = "Decimetre",
            Symbol = "dm"
        };

        public static readonly Unit Centimetre = new Unit
        {
            Id = 4,
            DisplayName = "Centimetre",
            Symbol = "cm"
        };

        public static readonly Unit Millimetre = new Unit
        {
            Id = 5,
            DisplayName = "Millimetre",
            Symbol = "mm"
        };

        public static readonly Unit Micrometre = new Unit
        {
            Id = 6,
            DisplayName = "Micrometre",
            Symbol = "μm"
        };

        public static readonly Unit Nanometre = new Unit
        {
            Id = 7,
            DisplayName = "Nanometre",
            Symbol = "nm"
        };

        public static readonly Unit Mile = new Unit
        {
            Id = 8,
            DisplayName = "Mile",
            Symbol = "mi"
        };

        public static readonly Unit Yard = new Unit
        {
            Id = 9,
            DisplayName = "Yard",
            Symbol = "yd"
        };

        public static readonly Unit Foot = new Unit
        {
            Id = 10,
            DisplayName = "Foot",
            Symbol = "ft"
        };

        public static readonly Unit Inch = new Unit
        {
            Id = 11,
            DisplayName = "Inch",
            Symbol = "in"
        };

        public static readonly Unit NauticalMile = new Unit
        {
            Id = 12,
            DisplayName = "Nautical Mile",
            Symbol = "nmi"
        };

        public static readonly List<Unit> LengthUnits = new List<Unit>
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
