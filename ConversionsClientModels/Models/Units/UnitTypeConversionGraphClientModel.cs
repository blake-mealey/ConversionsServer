using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ConversionsClientModels.Models.Units
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class UnitTypeConversionGraphClientModel
    {
        public UnitTypeClientModel UnitType;

        public Dictionary<int, Dictionary<int, double>> ConversionGraph;
    }
}
