using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ConversionsClientModels.Models.Conversions
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class UnitClientModel
    {
        public string Symbol;

        public string DisplayName;
    }
}
