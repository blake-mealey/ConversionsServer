using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ConversionsClientModels.Models.Units
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class UnitClientModel
    {
        public int Id;

        public string DisplayName;

        public string Symbol;
    }
}
