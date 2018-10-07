using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ConversionsClientModels.Models.Lists
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ConverterListClientModel
    {
        public string Id;

        public string DisplayName;

        public List<ConverterClientModel> Converters;
    }
}
