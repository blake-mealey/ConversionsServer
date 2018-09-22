using ConversionsDb.Models.Units;
using System.Collections.Generic;

namespace ConversionsDb.SeedData
{
    public static class RelativeValueData
    {
        #region Distance Values
        private static readonly RelativeValue MetreToKilometre = new RelativeValue
        {
            BaseUnitId = UnitData.Metre.Id,
            UnitId = UnitData.Kilometre.Id,
            Value = 1e3
        };

        private static readonly RelativeValue MetreToMetre = new RelativeValue
        {
            BaseUnitId = UnitData.Metre.Id,
            UnitId = UnitData.Metre.Id,
            Value = 1e0
        };

        private static readonly RelativeValue MetreToDecimetre = new RelativeValue
        {
            BaseUnitId = UnitData.Metre.Id,
            UnitId = UnitData.Decimetre.Id,
            Value = 1e-1
        };

        private static readonly RelativeValue MetreToCentimetre = new RelativeValue
        {
            BaseUnitId = UnitData.Metre.Id,
            UnitId = UnitData.Centimetre.Id,
            Value = 1e-2
        };

        private static readonly RelativeValue MetreToMillimetre = new RelativeValue
        {
            BaseUnitId = UnitData.Metre.Id,
            UnitId = UnitData.Millimetre.Id,
            Value = 1e-3
        };

        private static readonly RelativeValue MetreToMicrometre = new RelativeValue
        {
            BaseUnitId = UnitData.Metre.Id,
            UnitId = UnitData.Micrometre.Id,
            Value = 1e-6
        };

        private static readonly RelativeValue MetreToNanometre = new RelativeValue
        {
            BaseUnitId = UnitData.Metre.Id,
            UnitId = UnitData.Nanometre.Id,
            Value = 1e-9
        };

        private static readonly RelativeValue MetreToFoot = new RelativeValue
        {
            BaseUnitId = UnitData.Metre.Id,
            UnitId = UnitData.Foot.Id,
            Value = 0.3048
        };

        private static readonly RelativeValue FootToMile = new RelativeValue
        {
            BaseUnitId = UnitData.Foot.Id,
            UnitId = UnitData.Mile.Id,
            Value = 5280.0
        };

        private static readonly RelativeValue FootToYard = new RelativeValue
        {
            BaseUnitId = UnitData.Foot.Id,
            UnitId = UnitData.Yard.Id,
            Value = 3.0
        };

        private static readonly RelativeValue FootToFoot = new RelativeValue
        {
            BaseUnitId = UnitData.Foot.Id,
            UnitId = UnitData.Foot.Id,
            Value = 1e0
        };

        private static readonly RelativeValue FootToInch = new RelativeValue
        {
            BaseUnitId = UnitData.Foot.Id,
            UnitId = UnitData.Inch.Id,
            Value = 1.0 / 12.0
        };

        private static readonly RelativeValue FootToNauticalMile = new RelativeValue
        {
            BaseUnitId = UnitData.Foot.Id,
            UnitId = UnitData.NauticalMile.Id,
            Value = 6076.12
        };

        public static readonly List<RelativeValue> DistanceRelativeValues = new List<RelativeValue>
        {
            MetreToKilometre, MetreToMetre, MetreToDecimetre, MetreToCentimetre, MetreToMillimetre, MetreToMicrometre, MetreToNanometre,
            MetreToFoot, FootToMile, FootToYard, FootToFoot, FootToInch, FootToNauticalMile
        };
        #endregion
    }
}
