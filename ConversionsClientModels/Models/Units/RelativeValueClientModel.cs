using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ConversionsClientModels.Models.Units
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class RelativeValueClientModel
    {
        public int BaseUnitId;

        public double Value;
    }
}
