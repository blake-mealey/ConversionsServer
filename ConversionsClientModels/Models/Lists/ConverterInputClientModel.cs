using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Chimerical.Conversions.ClientModels.Models.Lists
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ConverterInputClientModel : BaseConverterIoClientModel
    {
        public double Value;
    }
}
