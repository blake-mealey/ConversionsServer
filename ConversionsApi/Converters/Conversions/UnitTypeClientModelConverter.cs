using ConversionsClientModels.Models.Conversions;
using ConversionsDal.Entities.Conversions;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsApi.Converters.Conversions
{
    public static class UnitTypeClientModelConverter
    {
        public static List<UnitTypeClientModel> ToClientModels(this IEnumerable<UnitTypeEntity> entities)
        {
            return entities.Select(ToClientModel).ToList();
        }

        public static UnitTypeClientModel ToClientModel(this UnitTypeEntity entity)
        {
            return new UnitTypeClientModel
            {
                DisplayName = entity.DisplayName,
                BaseUnit = entity.BaseUnit.ToClientModel(),
                Units = entity.Units.ToClientModels()
            };
        }
    }
}
