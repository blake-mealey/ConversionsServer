using ConversionsClientModels.Models.Units;
using ConversionsDal.Entities.Units;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsApi.Converters.Units
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
                DisplayName = entity.DisplayName,
                Id = entity.Id,
                Symbol = entity.Symbol,
                RelativeValues = entity.RelativeValues.ToClientModels()
            };
        }
    }
}
