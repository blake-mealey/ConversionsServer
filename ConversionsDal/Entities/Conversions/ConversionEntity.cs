using ConversionsDb.Models.Conversions;

namespace ConversionsDal.Entities.Conversions
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
