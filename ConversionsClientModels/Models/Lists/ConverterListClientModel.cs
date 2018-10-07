using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Chimerical.Conversions.ClientModels.Models.Lists
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ConverterListClientModel
    {
        public string Id;

        public string DisplayName;

        public List<ConverterClientModel> Converters;
    }
}
