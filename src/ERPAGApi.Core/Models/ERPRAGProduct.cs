#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using Newtonsoft.Json;

namespace ERPAGApi.Core.Models
{
    public class ERPAGProduct
    {

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("onHand")]
        public decimal OnHand { get; set; }

        [JsonProperty("sellingPrice")]
        public decimal SellingPrice { get; set; }

        [JsonProperty("stockPrice")]
        public decimal StockPrice { get; set; }

        [JsonProperty("itemType")]
        public string ItemType { get; set; }
        public string Category { get; set; }
    }
}
