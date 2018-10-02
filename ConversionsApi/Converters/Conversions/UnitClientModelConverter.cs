using ConversionsClientModels.Models.Conversions;
using ConversionsDal.Entities.Conversions;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsApi.Converters.Conversions
{
    public static class UnitClientModelConverter
    {
        public static List<UnitClientModel> ToClientModels(this IEnumerable<UnitEntity> entities)
        {
            return entities.Select(ToClientModel).ToList();
        }

        public static UnitClientModel ToClientModel(this UnitEntity entity)
        {
            return new UnitClientModel
            {
                Symbol = entity.Symbol,
                DisplayName = entity.DisplayName
            };
        }
    }
}
