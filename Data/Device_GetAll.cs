using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryProject.Data
{
    public class Device_GetAll
    {
        [JsonProperty("DevId")]
        public int DevId { get; set; }
        
        [JsonProperty("DevType")]
        public string DevType { get; set; }

        [JsonProperty("DevTypeOther")]
        public string DevTypeOther { get; set; }

        [JsonProperty("Make")]
        public string Make { get; set; }

        [JsonProperty("Model")]
        public string Model { get; set; }

        [JsonProperty("Owner")]
        public string Owner { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Serial")]
        public string Serial { get; set; }

        [JsonProperty("PurchaseDate")]
        public DateTime PurchaseDate { get; set; }

        [JsonProperty("WarrantyExpDate")]
        public DateTime WarrantyExpDate { get; set; }

        [JsonProperty("ServiceExpDate")]
        public DateTime ServiceExpDate { get; set; }

        [JsonProperty("Value")]
        public int Value { get; set; }

        [JsonProperty("Size")]
        public int Size { get; set; }

        [JsonProperty("Toner")]
        public int Toner { get; set; }

        [JsonProperty("MacAddress")]
        public int MacAddress{ get; set; }

        [JsonProperty("IPAddress")]
        public int IPAddress { get; set; }

        [JsonProperty("CellNumber")]
        public int CellNumber { get; set; }

        [JsonProperty("UpdDate")]
        public DateTime UpdDate{ get; set; }

        [JsonProperty("DevStatus")]
        public string DevStatus { get; set; }


    }
}
