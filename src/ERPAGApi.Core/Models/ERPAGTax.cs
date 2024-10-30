namespace ERPAGApi.Core.Models
{
    public class ERPAGTax
    {

        [JsonProperty("taxRates")]
        public ERPAGTaxRates TaxRates { get; set; }
    }
}
