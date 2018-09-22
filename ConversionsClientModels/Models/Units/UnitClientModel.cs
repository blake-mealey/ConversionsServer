using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ConversionsClientModels.Models.Units
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class UnitClientModel
    {
        public int Id;

        public string DisplayName;

        public string Symbol;

        public List<RelativeValueClientModel> RelativeValues;
    }
}
