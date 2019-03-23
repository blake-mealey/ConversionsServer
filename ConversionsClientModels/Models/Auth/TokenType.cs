using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Chimerical.Conversions.ClientModels.Models.Auth
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TokenType
    {
        Bearer
    }
}
