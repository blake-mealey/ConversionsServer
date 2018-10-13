using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Chimerical.Conversions.ClientModels.Models.Lists
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class SimpleConverterClientModel
    {
        public string InputUnitDisplayName;

        public List<string> OutputUnitDisplayNames;
    }
}
