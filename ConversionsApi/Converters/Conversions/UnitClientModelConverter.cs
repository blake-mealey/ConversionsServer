using Chimerical.Conversions.ClientModels.Models.Conversions;
using Chimerical.Conversions.Dal.Entities.Conversions;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Api.Converters.Conversions
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
