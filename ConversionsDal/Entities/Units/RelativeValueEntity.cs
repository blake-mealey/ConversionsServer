using ConversionsDb.Models.Units;

namespace ConversionsDal.Entities.Units
{
    public class RelativeValueEntity
    {
        public RelativeValueEntity(RelativeValue relativeValue)
        {
            BaseUnitId = relativeValue.BaseUnitId;
            UnitId = relativeValue.UnitId;
            Value = relativeValue.Value;
        }

        public int BaseUnitId;

        public int UnitId;

        public double Value;
    }
}
