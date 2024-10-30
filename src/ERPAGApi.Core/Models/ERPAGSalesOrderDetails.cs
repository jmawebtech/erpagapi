namespace ERPAGApi.Core.Models
{
    public class ERPAGSalesOrderDetails
    {

        [JsonProperty("salesOrder")]
        public string SalesOrderNumber { get; set; }

        [JsonProperty("documentDate")]
        public string DocumentDate { get; set; }

        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }
    }
}
