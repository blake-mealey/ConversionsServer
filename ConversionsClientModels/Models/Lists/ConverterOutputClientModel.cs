using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Chimerical.Conversions.ClientModels.Models.Lists
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ConverterOutputClientModel : BaseConverterIoClientModel
    {
        public string Id;
    }
}
