namespace ERPAGApi.Core.Models
{

    public class ERPAGSalesOrder
    {

        [JsonProperty("salesOrder")]
        public ERPAGSalesOrderDetails SalesOrderDetails { get; set; }

        [JsonProperty("customer")]
        public ERPAGCustomer Customer { get; set; }

        [JsonProperty("billingAddress")]
        public ERPAGBillingAddress BillingAddress { get; set; }

        [JsonProperty("shippingAddress")]
        public ERPAGShippingAddress ShippingAddress { get; set; }

        [JsonProperty("items")]
        public IList<ERPAGItem> Items { get; set; }

        [JsonProperty("taxes")]
        public IList<ERPAGTax> Taxes { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

    }
}
