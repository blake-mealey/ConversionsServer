using ConversionsDb.Models.Units;
using System.Collections.Generic;

namespace ConversionsDb.SeedData
{
    public static class UnitData
    {
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
            DisplayName = "NauticalMile",
            Symbol = "nmi"
        };

        public static readonly List<Unit> LengthUnits = new List<Unit>
        {
            Kilometre, Metre, Decimetre, Centimetre, Millimetre, Micrometre, Nanometre, Mile, Yard, Foot, Inch, NauticalMile
        };
        #endregion
    }
}
