using Newtonsoft.Json;
using System.Collections.Generic;

namespace BitPayAPI
{
    public class RefundInfo
    {
        [JsonProperty(PropertyName = "supportRequest")]
        public string SupportRequest { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "amounts")]
        public Dictionary<string, long> Amounts { get; set; }
    }
}