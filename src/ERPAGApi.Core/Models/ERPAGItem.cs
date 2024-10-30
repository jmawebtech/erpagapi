namespace ERPAGApi.Core.Models
{
    public class ERPAGItem
    {

        [JsonProperty("productsAndServices")]
        public ERPAGProductsAndServices ProductsAndServices { get; set; }

        [JsonProperty("defaultUom")]
        public ERPAGDefaultUom DefaultUom { get; set; }

        [JsonProperty("discountPercent")]
        public decimal DiscountPercent { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("taxPercent")]
        public decimal TaxPercent { get; set; }

        [JsonProperty("productType")]
        public string ProductType { get; set; }
    }
}
