using ConversionsDb.Models.Conversions;
using System;
using System.Collections.Generic;

namespace ConversionsDb.SeedData.Conversions
{
    public static class ConversionData
    {
        private const double SiMultiplier = 1000.0;

        #region Time Conversions
        private static readonly Conversion CenturyToDecade = new Conversion
        {
            FromUnitSymbol = UnitData.Century.Symbol,
            ToUnitSymbol = UnitData.Decade.Symbol,
            Multiplier = 10.0
        };

        private static readonly Conversion DecadeToYear = new Conversion
        {
            FromUnitSymbol = UnitData.Decade.Symbol,
            ToUnitSymbol = UnitData.Year.Symbol,
            Multiplier = 10.0
        };

        private static readonly Conversion YearToMonth = new Conversion
        {
            FromUnitSymbol = UnitData.Year.Symbol,
            ToUnitSymbol = UnitData.Month.Symbol,
            Multiplier = 12.0
        };

        private static readonly Conversion YearToDay = new Conversion
        {
            FromUnitSymbol = UnitData.Year.Symbol,
            ToUnitSymbol = UnitData.Day.Symbol,
            Multiplier = 365.0
        };

        private static readonly Conversion WeekToDay = new Conversion
        {
            FromUnitSymbol = UnitData.Week.Symbol,
            ToUnitSymbol = UnitData.Day.Symbol,
            Multiplier = 365.0
        };

        private static readonly Conversion DayToHour = new Conversion
        {
            FromUnitSymbol = UnitData.Day.Symbol,
            ToUnitSymbol = UnitData.Hour.Symbol,
            Multiplier = 24.0
        };

        private static readonly Conversion HourToMinute = new Conversion
        {
            FromUnitSymbol = UnitData.Hour.Symbol,
            ToUnitSymbol = UnitData.Minute.Symbol,
            Multiplier = 60.0
        };

        private static readonly Conversion MinuteToSecond = new Conversion
        {
            FromUnitSymbol = UnitData.Minute.Symbol,
            ToUnitSymbol = UnitData.Second.Symbol,
            Multiplier = 60.0
        };

        private static readonly Conversion SecondToMillisecond = new Conversion
        {
            FromUnitSymbol = UnitData.Second.Symbol,
            ToUnitSymbol = UnitData.Millisecond.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion MillisecondToMicrosecond = new Conversion
        {
            FromUnitSymbol = UnitData.Millisecond.Symbol,
            ToUnitSymbol = UnitData.Microsecond.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion MicrosecondToNanosecond = new Conversion
        {
            FromUnitSymbol = UnitData.Microsecond.Symbol,
            ToUnitSymbol = UnitData.Nanosecond.Symbol,
            Multiplier = SiMultiplier
        };

        public static readonly List<Conversion> TimeConversions = new List<Conversion>
        {
            CenturyToDecade,
            DecadeToYear,
            YearToMonth,
            YearToDay,
            WeekToDay,
            DayToHour,
            HourToMinute,
            MinuteToSecond,
            SecondToMillisecond,
            MillisecondToMicrosecond,
            MicrosecondToNanosecond
        };
        #endregion

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

        #region Digital Storage
        private static readonly Conversion ByteToBit = new Conversion
        {
            FromUnitSymbol = UnitData.Byte.Symbol,
            ToUnitSymbol = UnitData.Bit.Symbol,
            Multiplier = 8.0
        };

        private static readonly Conversion KibibitToKilobit = new Conversion
        {
            FromUnitSymbol = UnitData.Kibibit.Symbol,
            ToUnitSymbol = UnitData.Kilobit.Symbol,
            Multiplier = 1.024
        };

        private static readonly Conversion KibibyteToKilobyte = new Conversion
        {
            FromUnitSymbol = UnitData.Kibibyte.Symbol,
            ToUnitSymbol = UnitData.Kilobyte.Symbol,
            Multiplier = 1.024
        };

        private static readonly Conversion PebibyteToTebibyte = new Conversion
        {
            FromUnitSymbol = UnitData.Pebibyte.Symbol,
            ToUnitSymbol = UnitData.Tebibyte.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion TebibyteToGibibyte = new Conversion
        {
            FromUnitSymbol = UnitData.Tebibyte.Symbol,
            ToUnitSymbol = UnitData.Gibibyte.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion GibibyteToMebibyte = new Conversion
        {
            FromUnitSymbol = UnitData.Gibibyte.Symbol,
            ToUnitSymbol = UnitData.Mebibyte.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion MebibyteToKibibyte = new Conversion
        {
            FromUnitSymbol = UnitData.Mebibyte.Symbol,
            ToUnitSymbol = UnitData.Kibibyte.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion KibibyteToByte = new Conversion
        {
            FromUnitSymbol = UnitData.Kibibyte.Symbol,
            ToUnitSymbol = UnitData.Byte.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion PetabyteToTerabyte = new Conversion
        {
            FromUnitSymbol = UnitData.Petabyte.Symbol,
            ToUnitSymbol = UnitData.Terabyte.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion TerabyteToGigabyte = new Conversion
        {
            FromUnitSymbol = UnitData.Terabyte.Symbol,
            ToUnitSymbol = UnitData.Gigabyte.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion GigabyteToMegabyte = new Conversion
        {
            FromUnitSymbol = UnitData.Gigabyte.Symbol,
            ToUnitSymbol = UnitData.Megabyte.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion MegabyteToKilobyte = new Conversion
        {
            FromUnitSymbol = UnitData.Megabyte.Symbol,
            ToUnitSymbol = UnitData.Kilobyte.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion KilobyteToByte = new Conversion
        {
            FromUnitSymbol = UnitData.Kilobyte.Symbol,
            ToUnitSymbol = UnitData.Byte.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion PebibitToTebibit = new Conversion
        {
            FromUnitSymbol = UnitData.Pebibit.Symbol,
            ToUnitSymbol = UnitData.Tebibit.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion TebibitToGibibit = new Conversion
        {
            FromUnitSymbol = UnitData.Tebibit.Symbol,
            ToUnitSymbol = UnitData.Gibibit.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion GibibitToMebibit = new Conversion
        {
            FromUnitSymbol = UnitData.Gibibit.Symbol,
            ToUnitSymbol = UnitData.Mebibit.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion MebibitToKibibit = new Conversion
        {
            FromUnitSymbol = UnitData.Mebibit.Symbol,
            ToUnitSymbol = UnitData.Kibibit.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion KibibitToBit = new Conversion
        {
            FromUnitSymbol = UnitData.Kibibit.Symbol,
            ToUnitSymbol = UnitData.Bit.Symbol,
            Multiplier = 1024.0
        };

        private static readonly Conversion PetabitToTerabit = new Conversion
        {
            FromUnitSymbol = UnitData.Petabit.Symbol,
            ToUnitSymbol = UnitData.Terabit.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion TerabitToGigabit = new Conversion
        {
            FromUnitSymbol = UnitData.Terabit.Symbol,
            ToUnitSymbol = UnitData.Gigabit.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion GigabitToMegabit = new Conversion
        {
            FromUnitSymbol = UnitData.Gigabit.Symbol,
            ToUnitSymbol = UnitData.Megabit.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion MegabitToKilobit = new Conversion
        {
            FromUnitSymbol = UnitData.Megabit.Symbol,
            ToUnitSymbol = UnitData.Kilobit.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion KilobitToBit = new Conversion
        {
            FromUnitSymbol = UnitData.Kilobit.Symbol,
            ToUnitSymbol = UnitData.Bit.Symbol,
            Multiplier = SiMultiplier
        };

        public static readonly List<Conversion> DigitalStorageConversions = new List<Conversion>
        {
            ByteToBit,
            KibibitToKilobit,
            KibibyteToKilobyte,
            PebibyteToTebibyte,
            TebibyteToGibibyte,
            GibibyteToMebibyte,
            MebibyteToKibibyte,
            KibibyteToByte,
            PetabyteToTerabyte,
            TerabyteToGigabyte,
            GigabyteToMegabyte,
            MegabyteToKilobyte,
            KilobyteToByte,
            PebibitToTebibit,
            TebibitToGibibit,
            GibibitToMebibit,
            MebibitToKibibit,
            KibibitToBit,
            PetabitToTerabit,
            TerabitToGigabit,
            GigabitToMegabit,
            MegabitToKilobit,
            KilobitToBit
        };
        #endregion

        #region Distance Conversion
        private static readonly Conversion KilometreToMetre = new Conversion
        {
            FromUnitSymbol = UnitData.Kilometre.Symbol,
            ToUnitSymbol = UnitData.Metre.Symbol,
            Multiplier = SiMultiplier
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
            Multiplier = SiMultiplier
        };

        private static readonly Conversion MillimetreToMicrometre = new Conversion
        {
            FromUnitSymbol = UnitData.Millimetre.Symbol,
            ToUnitSymbol = UnitData.Micrometre.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion MicrometreToNanometre = new Conversion
        {
            FromUnitSymbol = UnitData.Micrometre.Symbol,
            ToUnitSymbol = UnitData.Nanometre.Symbol,
            Multiplier = SiMultiplier
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
            MillimetreToMicrometre,
            MicrometreToNanometre,
            FootToMetre,
            MileToFoot,
            YardToFoot,
            FootToInch,
            NauticalMileToFoot
        };
        #endregion

        #region Energy Conversions
        private static readonly Conversion KilojouleToJoule = new Conversion
        {
            FromUnitSymbol = UnitData.Kilojoule.Symbol,
            ToUnitSymbol = UnitData.Joule.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion GramCalorieToJoule = new Conversion
        {
            FromUnitSymbol = UnitData.GramCalorie.Symbol,
            ToUnitSymbol = UnitData.Joule.Symbol,
            Multiplier = 4.184
        };

        private static readonly Conversion KilocalorieToGramCalorie = new Conversion
        {
            FromUnitSymbol = UnitData.Kilocalorie.Symbol,
            ToUnitSymbol = UnitData.GramCalorie.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion WattHourToJoule = new Conversion
        {
            FromUnitSymbol = UnitData.WattHour.Symbol,
            ToUnitSymbol = UnitData.Joule.Symbol,
            Multiplier = 3600.0
        };

        private static readonly Conversion KilowattHourToWattHour = new Conversion
        {
            FromUnitSymbol = UnitData.KilowattHour.Symbol,
            ToUnitSymbol = UnitData.WattHour.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion JouleToElectronvolt = new Conversion
        {
            FromUnitSymbol = UnitData.Joule.Symbol,
            ToUnitSymbol = UnitData.Electronvolt.Symbol,
            Multiplier = 6.242E18
        };

        private static readonly Conversion BritishThermalUnitToJoule = new Conversion
        {
            FromUnitSymbol = UnitData.BritishThermalUnit.Symbol,
            ToUnitSymbol = UnitData.Joule.Symbol,
            Multiplier = 1055.06
        };

        private static readonly Conversion UsThermToBritishThermalUnit = new Conversion
        {
            FromUnitSymbol = UnitData.UsTherm.Symbol,
            ToUnitSymbol = UnitData.BritishThermalUnit.Symbol,
            Multiplier = 99976.1
        };

        private static readonly Conversion BritishThermalUnitToFootPound = new Conversion
        {
            FromUnitSymbol = UnitData.BritishThermalUnit.Symbol,
            ToUnitSymbol = UnitData.FootPound.Symbol,
            Multiplier = 778.169
        };

        public static readonly List<Conversion> EnergyConversions = new List<Conversion>
        {
            KilojouleToJoule,
            GramCalorieToJoule,
            KilocalorieToGramCalorie,
            WattHourToJoule,
            KilowattHourToWattHour,
            JouleToElectronvolt,
            BritishThermalUnitToJoule,
            UsThermToBritishThermalUnit,
            BritishThermalUnitToFootPound
        };
        #endregion

        #region Frequency Conversions
        private static readonly Conversion GigahertzToMegahertz = new Conversion
        {
            FromUnitSymbol = UnitData.Gigahertz.Symbol,
            ToUnitSymbol = UnitData.Megahertz.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion MegahertzToKilohertz = new Conversion
        {
            FromUnitSymbol = UnitData.Megahertz.Symbol,
            ToUnitSymbol = UnitData.Kilohertz.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion KilohertzToHertz = new Conversion
        {
            FromUnitSymbol = UnitData.Kilohertz.Symbol,
            ToUnitSymbol = UnitData.Hertz.Symbol,
            Multiplier = SiMultiplier
        };

        public static readonly List<Conversion> FrequencyConversions = new List<Conversion>
        {
            GigahertzToMegahertz,
            MegahertzToKilohertz,
            KilohertzToHertz
        };
        #endregion

        #region Fuel Economy Conversions
        // TODO: FIX MULTIPLIER
        private static readonly Conversion KilometrePerLitreToUsMilesPerGallon = new Conversion
        {
            FromUnitSymbol = UnitData.KilometrePerLitre.Symbol,
            ToUnitSymbol = UnitData.UsMilesPerGallon.Symbol,
            Multiplier = KilometreToMetre.Multiplier * (1.0 / FootToMetre.Multiplier) * (1.0 / MileToFoot.Multiplier)
        };

        // TODO: FIX MULTIPLIER
        private static readonly Conversion UsMilesPerGallonToMilesPerGallonImperial = new Conversion
        {
            FromUnitSymbol = UnitData.UsMilesPerGallon.Symbol,
            ToUnitSymbol = UnitData.MilesPerGallonImperial.Symbol,
            Multiplier = KilometreToMetre.Multiplier * (1.0 / FootToMetre.Multiplier) * (1.0 / MileToFoot.Multiplier)
        };

        public static readonly List<Conversion> FuelEconomyConversions = new List<Conversion>
        {
            KilometrePerLitreToUsMilesPerGallon,
            UsMilesPerGallonToMilesPerGallonImperial
        };
        #endregion

        #region Mass Conversions
        private static readonly Conversion TonneToKilogram = new Conversion
        {
            FromUnitSymbol = UnitData.Tonne.Symbol,
            ToUnitSymbol = UnitData.Kilogram.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion KilogramToGram = new Conversion
        {
            FromUnitSymbol = UnitData.Kilogram.Symbol,
            ToUnitSymbol = UnitData.Gram.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion GramToMilligram = new Conversion
        {
            FromUnitSymbol = UnitData.Gram.Symbol,
            ToUnitSymbol = UnitData.Milligram.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion MilligramToMicrogram = new Conversion
        {
            FromUnitSymbol = UnitData.Milligram.Symbol,
            ToUnitSymbol = UnitData.Microgram.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion KilogramToPound = new Conversion
        {
            FromUnitSymbol = UnitData.Kilogram.Symbol,
            ToUnitSymbol = UnitData.Pound.Symbol,
            Multiplier = 2.20462262185
        };

        private static readonly Conversion PoundToOunce = new Conversion
        {
            FromUnitSymbol = UnitData.Pound.Symbol,
            ToUnitSymbol = UnitData.Ounce.Symbol,
            Multiplier = 16.0
        };

        private static readonly Conversion StoneToPound = new Conversion
        {
            FromUnitSymbol = UnitData.Stone.Symbol,
            ToUnitSymbol = UnitData.Pound.Symbol,
            Multiplier = 14.0
        };

        private static readonly Conversion UsTonToPound = new Conversion
        {
            FromUnitSymbol = UnitData.UsTon.Symbol,
            ToUnitSymbol = UnitData.Pound.Symbol,
            Multiplier = 2000.0
        };

        private static readonly Conversion ImperialTonToUsTon = new Conversion
        {
            FromUnitSymbol = UnitData.ImperialTon.Symbol,
            ToUnitSymbol = UnitData.UsTon.Symbol,
            Multiplier = 1.12
        };

        public static readonly List<Conversion> MassConversions = new List<Conversion>
        {
            TonneToKilogram,
            KilogramToGram,
            GramToMilligram,
            MilligramToMicrogram,
            KilogramToPound,
            PoundToOunce,
            StoneToPound,
            UsTonToPound,
            ImperialTonToUsTon
        };
        #endregion

        #region Plane Angle Conversions
        private static readonly Conversion MinuteOfArcToSecondOfArc = new Conversion
        {
            FromUnitSymbol = UnitData.MinuteOfArc.Symbol,
            ToUnitSymbol = UnitData.SecondOfArc.Symbol,
            Multiplier = MinuteToSecond.Multiplier
        };

        private static readonly Conversion RadianToSecondOfArc = new Conversion
        {
            FromUnitSymbol = UnitData.Radian.Symbol,
            ToUnitSymbol = UnitData.SecondOfArc.Symbol,
            Multiplier = 206265.0
        };

        private static readonly Conversion RadianToGradian = new Conversion
        {
            FromUnitSymbol = UnitData.Radian.Symbol,
            ToUnitSymbol = UnitData.Gradian.Symbol,
            Multiplier = 200.0 / Math.PI
        };

        private static readonly Conversion RadianToMilliradian = new Conversion
        {
            FromUnitSymbol = UnitData.Radian.Symbol,
            ToUnitSymbol = UnitData.Milliradian.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion RadianToDegree = new Conversion
        {
            FromUnitSymbol = UnitData.Radian.Symbol,
            ToUnitSymbol = UnitData.Degree.Symbol,
            Multiplier = 180.0 / Math.PI
        };

        public static readonly List<Conversion> PlaneAngleConversions = new List<Conversion>
        {
            MinuteOfArcToSecondOfArc,
            RadianToSecondOfArc,
            RadianToGradian,
            RadianToMilliradian,
            RadianToDegree
        };
        #endregion

        #region Pressure Conversions
        private static readonly Conversion AtmosphereToPascal = new Conversion
        {
            FromUnitSymbol = UnitData.Atmosphere.Symbol,
            ToUnitSymbol = UnitData.Pascal.Symbol,
            Multiplier = 101325.0
        };

        private static readonly Conversion AtmosphereToTorr = new Conversion
        {
            FromUnitSymbol = UnitData.Atmosphere.Symbol,
            ToUnitSymbol = UnitData.Torr.Symbol,
            Multiplier = 760.0
        };

        private static readonly Conversion BarToPascal = new Conversion
        {
            FromUnitSymbol = UnitData.Bar.Symbol,
            ToUnitSymbol = UnitData.Pascal.Symbol,
            Multiplier = 100000.0
        };

        private static readonly Conversion PoundsPerSquareInchToPascal = new Conversion
        {
            FromUnitSymbol = UnitData.PoundsPerSquareInch.Symbol,
            ToUnitSymbol = UnitData.Pascal.Symbol,
            Multiplier = 6894.757
        };

        public static readonly List<Conversion> PressureConversions = new List<Conversion>
        {
            AtmosphereToPascal,
            AtmosphereToTorr,
            BarToPascal,
            PoundsPerSquareInchToPascal
        };
        #endregion

        #region Speed Conversions
        private static readonly Conversion MetrePerSecondToKilometrePerHour = new Conversion
        {
            FromUnitSymbol = UnitData.MetrePerSecond.Symbol,
            ToUnitSymbol = UnitData.KilometrePerHour.Symbol,
            Multiplier = (HourToMinute.Multiplier * MinuteToSecond.Multiplier) / (KilometreToMetre.Multiplier)
        };

        private static readonly Conversion FootPerSecondToMetrePerSecond = new Conversion
        {
            FromUnitSymbol = UnitData.FootPerSecond.Symbol,
            ToUnitSymbol = UnitData.MetrePerSecond.Symbol,
            Multiplier = FootToMetre.Multiplier
        };

        private static readonly Conversion MilePerHourToKilometrePerHour = new Conversion
        {
            FromUnitSymbol = UnitData.MilePerHour.Symbol,
            ToUnitSymbol = UnitData.KilometrePerHour.Symbol,
            Multiplier = MileToFoot.Multiplier * FootToMetre.Multiplier * (1.0 / KilometreToMetre.Multiplier)
        };

        private static readonly Conversion KnotToMilePerHour = new Conversion
        {
            FromUnitSymbol = UnitData.Knot.Symbol,
            ToUnitSymbol = UnitData.MilePerHour.Symbol,
            Multiplier = 1.15078
        };

        public static readonly List<Conversion> SpeedConversions = new List<Conversion>
        {
            MetrePerSecondToKilometrePerHour,
            FootPerSecondToMetrePerSecond,
            MilePerHourToKilometrePerHour,
            KnotToMilePerHour
        };
        #endregion

        #region Volume Conversions
        private static readonly Conversion CubicMetreToLitre = new Conversion
        {
            FromUnitSymbol = UnitData.CubicMetre.Symbol,
            ToUnitSymbol = UnitData.Litre.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion LitreToMillilitre = new Conversion
        {
            FromUnitSymbol = UnitData.Litre.Symbol,
            ToUnitSymbol = UnitData.Millilitre.Symbol,
            Multiplier = SiMultiplier
        };

        private static readonly Conversion CubicFootToCubicMetre = new Conversion
        {
            FromUnitSymbol = UnitData.CubicMetre.Symbol,
            ToUnitSymbol = UnitData.CubicFoot.Symbol,
            Multiplier = Math.Pow(FootToMetre.Multiplier, 3)
        };

        private static readonly Conversion CubicFootToCubicInch = new Conversion
        {
            FromUnitSymbol = UnitData.CubicFoot.Symbol,
            ToUnitSymbol = UnitData.CubicInch.Symbol,
            Multiplier = Math.Pow(FootToInch.Multiplier, 3)
        };

        private static readonly Conversion UsLiquidGallonToLitre = new Conversion
        {
            FromUnitSymbol = UnitData.UsLiquidGallon.Symbol,
            ToUnitSymbol = UnitData.Litre.Symbol,
            Multiplier = 3.78541
        };

        private static readonly Conversion ImperialGallonToLitre = new Conversion
        {
            FromUnitSymbol = UnitData.ImperialGallon.Symbol,
            ToUnitSymbol = UnitData.Litre.Symbol,
            Multiplier = 4.54609
        };

        private static readonly Conversion ImperialGallonToImperialQuart = new Conversion
        {
            FromUnitSymbol = UnitData.ImperialGallon.Symbol,
            ToUnitSymbol = UnitData.ImperialQuart.Symbol,
            Multiplier = 4.0
        };

        private static readonly Conversion ImperialQuartToImperialPint = new Conversion
        {
            FromUnitSymbol = UnitData.ImperialQuart.Symbol,
            ToUnitSymbol = UnitData.ImperialPint.Symbol,
            Multiplier = 2.0
        };

        private static readonly Conversion ImperialPintToImperialCup = new Conversion
        {
            FromUnitSymbol = UnitData.ImperialPint.Symbol,
            ToUnitSymbol = UnitData.ImperialCup.Symbol,
            Multiplier = 1.75975
        };

        private static readonly Conversion ImperialPintToImperialFluidOunce = new Conversion
        {
            FromUnitSymbol = UnitData.ImperialPint.Symbol,
            ToUnitSymbol = UnitData.ImperialFluidOunce.Symbol,
            Multiplier = 20.0
        };

        private static readonly Conversion ImperialFluidOunceToImperialTablespoon = new Conversion
        {
            FromUnitSymbol = UnitData.ImperialFluidOunce.Symbol,
            ToUnitSymbol = UnitData.ImperialTablespoon.Symbol,
            Multiplier = 1.6
        };

        private static readonly Conversion ImperialTablespoonToImperialTeaspoon = new Conversion
        {
            FromUnitSymbol = UnitData.ImperialTablespoon.Symbol,
            ToUnitSymbol = UnitData.ImperialTeaspoon.Symbol,
            Multiplier = 3.0
        };

        private static readonly Conversion UsLiquidGallonToUsLiquidQuart = new Conversion
        {
            FromUnitSymbol = UnitData.UsLiquidGallon.Symbol,
            ToUnitSymbol = UnitData.UsLiquidQuart.Symbol,
            Multiplier = 4.0
        };

        private static readonly Conversion UsLiquidQuartToUsLiquidPint = new Conversion
        {
            FromUnitSymbol = UnitData.UsLiquidQuart.Symbol,
            ToUnitSymbol = UnitData.UsLiquidPint.Symbol,
            Multiplier = 2.0
        };

        private static readonly Conversion UsLiquidPintToUsLegalCup = new Conversion
        {
            FromUnitSymbol = UnitData.UsLiquidPint.Symbol,
            ToUnitSymbol = UnitData.UsLegalCup.Symbol,
            Multiplier = 1.97157
        };

        private static readonly Conversion UsLiquidPintToUsFluidOunce = new Conversion
        {
            FromUnitSymbol = UnitData.UsLiquidPint.Symbol,
            ToUnitSymbol = UnitData.UsFluidOunce.Symbol,
            Multiplier = 16.0
        };

        private static readonly Conversion UsFluidOunceToUsTablespoon = new Conversion
        {
            FromUnitSymbol = UnitData.UsFluidOunce.Symbol,
            ToUnitSymbol = UnitData.UsTablespoon.Symbol,
            Multiplier = 2.0
        };

        private static readonly Conversion UsTablespoonToUTeaspoon = new Conversion
        {
            FromUnitSymbol = UnitData.UsTablespoon.Symbol,
            ToUnitSymbol = UnitData.UsTeaspoon.Symbol,
            Multiplier = 3.0
        };

        public static readonly List<Conversion> VolumeConversions = new List<Conversion>
        {
            CubicMetreToLitre,
            LitreToMillilitre,
            CubicFootToCubicMetre,
            CubicFootToCubicInch,
            UsLiquidGallonToLitre,
            ImperialGallonToLitre,
            ImperialGallonToImperialQuart,
            ImperialQuartToImperialPint,
            ImperialPintToImperialCup,
            ImperialPintToImperialFluidOunce,
            ImperialFluidOunceToImperialTablespoon,
            ImperialTablespoonToImperialTeaspoon,
            UsLiquidGallonToUsLiquidQuart,
            UsLiquidQuartToUsLiquidPint,
            UsLiquidPintToUsLegalCup,
            UsLiquidPintToUsFluidOunce,
            UsFluidOunceToUsTablespoon,
            UsTablespoonToUTeaspoon
        };
        #endregion
    }
}
