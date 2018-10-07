using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ConversionsClientModels.Models.Lists
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ConverterClientModel
    {
        public string Id;

        public int UnitTypeId;

        public ConverterInputClientModel Input;

        public List<ConverterOutputClientModel> Outputs;
    }
}
