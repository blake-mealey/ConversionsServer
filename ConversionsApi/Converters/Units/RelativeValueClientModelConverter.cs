using ConversionsClientModels.Models.Units;
using ConversionsDal.Entities.Units;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsApi.Converters.Units
{
    public static class RelativeValueClientModelConverter
    {
        public static List<RelativeValueClientModel> ToClientModels(this IEnumerable<RelativeValueEntity> entities)
        {
            return entities.Select(ToClientModel).ToList();
        }

        public static RelativeValueClientModel ToClientModel(this RelativeValueEntity entity)
        {
            return new RelativeValueClientModel
            {
                BaseUnitId = entity.BaseUnitId,
                Value = entity.Value
            };
        }
    }
}
