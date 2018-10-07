using Chimerical.Conversions.ClientModels.Models.Lists;
using Chimerical.Conversions.Dal.Entities.Lists;
using System.Collections.Generic;
using System.Linq;

namespace Chimerical.Conversions.Api.Converters.Lists
{
    public static class ConverterListClientModelConverter
    {
        public static List<ConverterListClientModel> ToClientModels(this IEnumerable<ConverterListEntity> entities)
        {
            return entities.Select(ToClientModel).ToList();
        }

        public static ConverterListClientModel ToClientModel(this ConverterListEntity entity)
        {
            return new ConverterListClientModel
            {
                Id = GuidConverter.EncodeGuid(entity.Id),
                DisplayName = entity.DisplayName,
                Converters = entity.Converters.ToClientModels()
            };
        }
    }
}
