using Chimerical.Conversions.Db.Models.Conversions;
using System.Collections.Generic;

namespace Chimerical.Conversions.Db.SeedData.Conversions
{
    public static class UnitData
    {
        #region Area Units
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

        #region Digital Storage Units
        public static readonly Unit Bit = new Unit
        {
            Symbol = "bit",
            DisplayName = "Bit"
        };

        public static readonly Unit Kilobit = new Unit
        {
            Symbol = "kbit",
            DisplayName = "Kilobit"
        };

        public static readonly Unit Kibibit = new Unit
        {
            Symbol = "Kibit",
            DisplayName = "Kibibit"
        };

        public static readonly Unit Megabit = new Unit
        {
            Symbol = "Mbit",
            DisplayName = "Megabit"
        };

        public static readonly Unit Mebibit = new Unit
        {
            Symbol = "Mibit",
            DisplayName = "Mebibit"
        };

        public static readonly Unit Gigabit = new Unit
        {
            Symbol = "Gbit",
            DisplayName = "Gigabit"
        };

        public static readonly Unit Gibibit = new Unit
        {
            Symbol = "Gibit",
            DisplayName = "Gibibit"
        };

        public static readonly Unit Terabit = new Unit
        {
            Symbol = "Tbit",
            DisplayName = "Terabit"
        };

        public static readonly Unit Tebibit = new Unit
        {
            Symbol = "Tibit",
            DisplayName = "Tebibit"
        };

        public static readonly Unit Petabit = new Unit
        {
            Symbol = "Pbit",
            DisplayName = "Petabit"
        };

        public static readonly Unit Pebibit = new Unit
        {
            Symbol = "Pibit",
            DisplayName = "Pebibit"
        };

        public static readonly Unit Byte = new Unit
        {
            Symbol = "B",
            DisplayName = "Byte"
        };

        public static readonly Unit Kilobyte = new Unit
        {
            Symbol = "kB",
            DisplayName = "Kilobyte"
        };

        public static readonly Unit Kibibyte = new Unit
        {
            Symbol = "KiB",
            DisplayName = "Kibibyte"
        };

        public static readonly Unit Megabyte = new Unit
        {
            Symbol = "MB",
            DisplayName = "Megabyte"
        };

        public static readonly Unit Mebibyte = new Unit
        {
            Symbol = "MiB",
            DisplayName = "Mebibyte"
        };

        public static readonly Unit Gigabyte = new Unit
        {
            Symbol = "GB",
            DisplayName = "Gigabyte"
        };

        public static readonly Unit Gibibyte = new Unit
        {
            Symbol = "GiB",
            DisplayName = "Gibibyte"
        };

        public static readonly Unit Terabyte = new Unit
        {
            Symbol = "TB",
            DisplayName = "Terabyte"
        };

        public static readonly Unit Tebibyte = new Unit
        {
            Symbol = "TiB",
            DisplayName = "Tebibyte"
        };

        public static readonly Unit Petabyte = new Unit
        {
            Symbol = "PB",
            DisplayName = "Petabyte"
        };

        public static readonly Unit Pebibyte = new Unit
        {
            Symbol = "PiB",
            DisplayName = "Pebibyte"
        };

        public static readonly List<Unit> DigitalStorageUnits = new List<Unit>
        {
            Bit,
            Kilobit,
            Kibibit,
            Megabit,
            Mebibit,
            Gigabit,
            Gibibit,
            Terabit,
            Tebibit,
            Petabit,
            Pebibit,
            Byte,
            Kilobyte,
            Kibibyte,
            Megabyte,
            Mebibyte,
            Gigabyte,
            Gibibyte,
            Terabyte,
            Tebibyte,
            Petabyte,
            Pebibyte
        };
        #endregion

        #region Distance Units
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

        #region Energy Units
        public static readonly Unit Joule = new Unit
        {
            Symbol = "J",
            DisplayName = "Joule"
        };

        public static readonly Unit Kilojoule = new Unit
        {
            Symbol = "kJ",
            DisplayName = "Kilojoule"
        };

        public static readonly Unit GramCalorie = new Unit
        {
            Symbol = "cal",
            DisplayName = "Gram Calorie"
        };

        public static readonly Unit Kilocalorie = new Unit
        {
            Symbol = "kCal",
            DisplayName = "Kilocalorie"
        };

        public static readonly Unit WattHour = new Unit
        {
            Symbol = "Wh",
            DisplayName = "Watt Hour"
        };

        public static readonly Unit KilowattHour = new Unit
        {
            Symbol = "kWh",
            DisplayName = "Kilowatt Hour"
        };

        public static readonly Unit Electronvolt = new Unit
        {
            Symbol = "eV",
            DisplayName = "Electronvolt"
        };

        public static readonly Unit BritishThermalUnit = new Unit
        {
            Symbol = "Btu",
            DisplayName = "British Thermal Unit"
        };

        public static readonly Unit UsTherm = new Unit
        {
            Symbol = "thm",
            DisplayName = "US Therm"
        };

        public static readonly Unit FootPound = new Unit
        {
            Symbol = "ft-lb",
            DisplayName = "Foot-Pound"
        };

        public static readonly List<Unit> EnergyUnits = new List<Unit>
        {
            Joule,
            Kilojoule,
            GramCalorie,
            Kilocalorie,
            WattHour,
            KilowattHour,
            Electronvolt,
            BritishThermalUnit,
            UsTherm,
            FootPound
        };
        #endregion

        #region Frequency Units
        public static readonly Unit Hertz = new Unit
        {
            Symbol = "Hz",
            DisplayName = "Hertz"
        };

        public static readonly Unit Kilohertz = new Unit
        {
            Symbol = "kHz",
            DisplayName = "Kilohertz"
        };

        public static readonly Unit Megahertz = new Unit
        {
            Symbol = "MHz",
            DisplayName = "Megahertz"
        };

        public static readonly Unit Gigahertz = new Unit
        {
            Symbol = "GHz",
            DisplayName = "Gigahertz"
        };

        public static readonly List<Unit> FrequencyUnits = new List<Unit>
        {
            Hertz,
            Kilohertz,
            Megahertz,
            Gigahertz
        };
        #endregion

        #region Fuel Economy Units
        public static readonly Unit UsMilesPerGallon = new Unit
        {
            Symbol = "US mpg",
            DisplayName = "US Miles per Gallon"
        };

        public static readonly Unit MilesPerGallonImperial = new Unit
        {
            Symbol = "mpg",
            DisplayName = "Miles per Gallon (Imperial)"
        };

        public static readonly Unit KilometrePerLitre = new Unit
        {
            Symbol = "km/L",
            DisplayName = "Kilometre per Litre"
        };

        public static readonly List<Unit> FuelEconomyUnits = new List<Unit>
        {
            UsMilesPerGallon,
            MilesPerGallonImperial,
            KilometrePerLitre
        };
        #endregion

        #region Mass Units
        public static readonly Unit Tonne = new Unit
        {
            Symbol = "t",
            DisplayName = "Tonne"
        };

        public static readonly Unit Kilogram = new Unit
        {
            Symbol = "kg",
            DisplayName = "Kilogram"
        };

        public static readonly Unit Gram = new Unit
        {
            Symbol = "g",
            DisplayName = "Gram"
        };

        public static readonly Unit Milligram = new Unit
        {
            Symbol = "mg",
            DisplayName = "Milligram"
        };

        public static readonly Unit Microgram = new Unit
        {
            Symbol = "μg",
            DisplayName = "Microgram"
        };

        public static readonly Unit ImperialTon = new Unit
        {
            Symbol = "ton",
            DisplayName = "Imperial Ton"
        };

        public static readonly Unit UsTon = new Unit
        {
            Symbol = "US ton",
            DisplayName = "US Ton"
        };

        public static readonly Unit Stone = new Unit
        {
            Symbol = "st",
            DisplayName = "Stone"
        };

        public static readonly Unit Pound = new Unit
        {
            Symbol = "lbs",
            DisplayName = "Pound"
        };

        public static readonly Unit Ounce = new Unit
        {
            Symbol = "oz",
            DisplayName = "Ounce"
        };

        public static readonly List<Unit> MassUnits = new List<Unit>
        {
            Tonne,
            Kilogram,
            Gram,
            Milligram,
            Microgram,
            ImperialTon,
            UsTon,
            Stone,
            Pound,
            Ounce
        };
        #endregion

        #region Plane Angle Units
        public static readonly Unit Degree = new Unit
        {
            Symbol = "deg",
            DisplayName = "Degree"
        };

        public static readonly Unit Gradian = new Unit
        {
            Symbol = "gon",
            DisplayName = "Gradian"
        };

        public static readonly Unit Milliradian = new Unit
        {
            Symbol = "mrad",
            DisplayName = "Milliradian"
        };

        public static readonly Unit MinuteOfArc = new Unit
        {
            Symbol = "arcmin",
            DisplayName = "MinuteOfArc"
        };

        public static readonly Unit Radian = new Unit
        {
            Symbol = "rad",
            DisplayName = "Radian"
        };

        public static readonly Unit SecondOfArc = new Unit
        {
            Symbol = "arcsec",
            DisplayName = "SecondOfArc"
        };

        public static readonly List<Unit> PlaneAngleUnits = new List<Unit>
        {
            Degree,
            Gradian,
            Milliradian,
            MinuteOfArc,
            Radian,
            SecondOfArc
        };
        #endregion

        #region Pressure Units
        public static readonly Unit Atmosphere = new Unit
        {
            Symbol = "atm",
            DisplayName = "Atmosphere"
        };

        public static readonly Unit Bar = new Unit
        {
            Symbol = "bar",
            DisplayName = "Bar"
        };

        public static readonly Unit Pascal = new Unit
        {
            Symbol = "Pa",
            DisplayName = "Pascal"
        };

        public static readonly Unit PoundsPerSquareInch = new Unit
        {
            Symbol = "psi",
            DisplayName = "Pounds per Square Inch"
        };

        public static readonly Unit Torr = new Unit
        {
            Symbol = "Torr",
            DisplayName = "Torr"
        };

        public static readonly List<Unit> PressureUnits = new List<Unit>
        {
            Atmosphere,
            Bar,
            Pascal,
            PoundsPerSquareInch,
            Torr
        };
        #endregion

        #region Speed Units
        public static readonly Unit MilePerHour = new Unit
        {
            Symbol = "mph",
            DisplayName = "Mile per Hour"
        };

        public static readonly Unit FootPerSecond = new Unit
        {
            Symbol = "fps",
            DisplayName = "Foot per Second"
        };

        public static readonly Unit MetrePerSecond = new Unit
        {
            Symbol = "m/s",
            DisplayName = "Metre per Second"
        };

        public static readonly Unit KilometrePerHour = new Unit
        {
            Symbol = "km/h",
            DisplayName = "Kilometre per Hour"
        };

        public static readonly Unit Knot = new Unit
        {
            Symbol = "kn",
            DisplayName = "Knot"
        };

        public static readonly List<Unit> SpeedUnits = new List<Unit>
        {
            MilePerHour,
            FootPerSecond,
            MetrePerSecond,
            KilometrePerHour,
            Knot
        };
        #endregion

        #region Temperature Units
        //        public static readonly Unit Celsius = new Unit
        //        {
        //            Symbol = "°C",
        //            DisplayName = "Celsius"
        //        };
        //
        //        public static readonly Unit Fahrenheit = new Unit
        //        {
        //            Symbol = "°F",
        //            DisplayName = "Fahrenheit"
        //        };
        //
        //        public static readonly Unit Kelvin = new Unit
        //        {
        //            Symbol = "K",
        //            DisplayName = "Kelvin"
        //        };
        //
        //        public static readonly List<Unit> TemperatureUnits = new List<Unit>
        //        {
        //            Celsius,
        //            Fahrenheit,
        //            Kelvin
        //        };
        #endregion

        #region Time Units
        public static readonly Unit Nanosecond = new Unit
        {
            Symbol = "ns",
            DisplayName = "Nanosecond"
        };

        public static readonly Unit Microsecond = new Unit
        {
            Symbol = "μs",
            DisplayName = "Microsecond"
        };

        public static readonly Unit Millisecond = new Unit
        {
            Symbol = "ms",
            DisplayName = "Millisecond"
        };

        public static readonly Unit Second = new Unit
        {
            Symbol = "s",
            DisplayName = "Second"
        };

        public static readonly Unit Minute = new Unit
        {
            Symbol = "min",
            DisplayName = "Minute"
        };

        public static readonly Unit Hour = new Unit
        {
            Symbol = "hr",
            DisplayName = "Hour"
        };

        public static readonly Unit Day = new Unit
        {
            Symbol = "day",
            DisplayName = "Day"
        };

        public static readonly Unit Week = new Unit
        {
            Symbol = "week",
            DisplayName = "Week"
        };

        public static readonly Unit Month = new Unit
        {
            Symbol = "month",
            DisplayName = "Month"
        };

        public static readonly Unit Year = new Unit
        {
            Symbol = "yr",
            DisplayName = "Year"
        };

        public static readonly Unit Decade = new Unit
        {
            Symbol = "decade",
            DisplayName = "Decade"
        };

        public static readonly Unit Century = new Unit
        {
            Symbol = "century",
            DisplayName = "Century"
        };

        public static readonly List<Unit> TimeUnits = new List<Unit>
        {
            Nanosecond,
            Microsecond,
            Millisecond,
            Second,
            Minute,
            Hour,
            Day,
            Week,
            Month,
            Year,
            Decade,
            Century
        };
        #endregion

        #region Volume Units
        public static readonly Unit UsLiquidGallon = new Unit
        {
            Symbol = "US gal",
            DisplayName = "US Liquid Gallon"
        };

        public static readonly Unit UsLiquidQuart = new Unit
        {
            Symbol = "US quart",
            DisplayName = "US Liquid Quart"
        };

        public static readonly Unit UsLiquidPint = new Unit
        {
            Symbol = "US pt",
            DisplayName = "US Liquid Pint"
        };

        public static readonly Unit UsLegalCup = new Unit
        {
            Symbol = "US cup",
            DisplayName = "US Legal Cup"
        };

        public static readonly Unit UsFluidOunce = new Unit
        {
            Symbol = "US oz",
            DisplayName = "US Fluid Ounce"
        };

        public static readonly Unit UsTablespoon = new Unit
        {
            Symbol = "US tbsp",
            DisplayName = "US Tablespoon"
        };

        public static readonly Unit UsTeaspoon = new Unit
        {
            Symbol = "US tsp",
            DisplayName = "US Teaspoon"
        };

        public static readonly Unit CubicMetre = new Unit
        {
            Symbol = "m³",
            DisplayName = "CubicMetre"
        };

        public static readonly Unit Litre = new Unit
        {
            Symbol = "L",
            DisplayName = "Litre"
        };

        public static readonly Unit Millilitre = new Unit
        {
            Symbol = "mL",
            DisplayName = "Millilitre"
        };

        public static readonly Unit ImperialGallon = new Unit
        {
            Symbol = "gal",
            DisplayName = "Imperial Gallon"
        };

        public static readonly Unit ImperialQuart = new Unit
        {
            Symbol = "quart",
            DisplayName = "Imperial Quart"
        };

        public static readonly Unit ImperialPint = new Unit
        {
            Symbol = "pt",
            DisplayName = "Imperial Pint"
        };

        public static readonly Unit ImperialCup = new Unit
        {
            Symbol = "cup",
            DisplayName = "Imperial Cup"
        };

        public static readonly Unit ImperialFluidOunce = new Unit
        {
            Symbol = "fluid oz",
            DisplayName = "Imperial Fluid Ounce"
        };

        public static readonly Unit ImperialTablespoon = new Unit
        {
            Symbol = "tbsp",
            DisplayName = "Imperial Tablespoon"
        };

        public static readonly Unit ImperialTeaspoon = new Unit
        {
            Symbol = "tsp",
            DisplayName = "Imperial Teaspoon"
        };

        public static readonly Unit CubicFoot = new Unit
        {
            Symbol = "ft³",
            DisplayName = "Cubic Foot"
        };

        public static readonly Unit CubicInch = new Unit
        {
            Symbol = "in³",
            DisplayName = "Cubic Inch"
        };

        public static readonly List<Unit> VolumeUnits = new List<Unit>
        {
            UsLiquidGallon,
            UsLiquidQuart,
            UsLiquidPint,
            UsLegalCup,
            UsFluidOunce,
            UsTablespoon,
            UsTeaspoon,
            CubicMetre,
            Litre,
            Millilitre,
            ImperialGallon,
            ImperialQuart,
            ImperialPint,
            ImperialCup,
            ImperialFluidOunce,
            ImperialTablespoon,
            ImperialTeaspoon,
            CubicFoot,
            CubicInch
        };
        #endregion

        #region Astronomical Units

        public static readonly Unit Parsec = new Unit
        {
            Symbol = "pc",
            DisplayName = "Parsec"
        };

        /// <summary>
        /// Distance runned by light on a year time 
        /// </summary>
        public static readonly Unit LightYear = new Unit
        {
            Symbol = "ly",
            DisplayName = "LightYear"
        };

        /// <summary>
        /// Distance from Earth to Sun
        /// </summary>
        public static readonly Unit AstronomicalUnit = new Unit
        {
            Symbol = "au",
            DisplayName = "AstronomicalUnit"
        };

        public static readonly List<Unit> AstronomicalUnits = new List<Unit>
        {
            Parsec,
            LightYear,
            AstronomicalUnit
        };

        #endregion
    }
}
