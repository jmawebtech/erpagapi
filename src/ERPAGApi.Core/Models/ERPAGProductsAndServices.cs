namespace ERPAGApi.Core.Models
{
    public class ERPAGProductsAndServices
    {

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("eanUpc")]
        public string EanUpc { get; set; }
    }
}
