using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ConversionsClientModels.Models.Lists
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ConverterInputClientModel : BaseConverterIoClientModel
    {
        public double Value;
    }
}
