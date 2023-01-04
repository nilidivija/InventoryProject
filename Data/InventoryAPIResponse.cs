using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryProject.Data
{
    public class InventoryAPIResponse
    {
        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
