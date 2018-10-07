using ConversionsClientModels.Models.Lists;
using ConversionsDal.Entities.Lists;
using System.Collections.Generic;
using System.Linq;

namespace ConversionsApi.Converters.Lists
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
