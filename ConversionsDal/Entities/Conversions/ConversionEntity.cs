using Chimerical.Conversions.Db.Models.Conversions;

namespace Chimerical.Conversions.Dal.Entities.Conversions
{
    public class ConversionEntity
    {
        public ConversionEntity(Conversion conversion)
        {
            FromUnit = new UnitEntity(conversion.FromUnit);
            ToUnit = new UnitEntity(conversion.ToUnit);
            Multiplier = conversion.Multiplier;
        }

        public UnitEntity FromUnit;

        public UnitEntity ToUnit;

        public double Multiplier;
    }
}
