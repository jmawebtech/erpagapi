namespace ERPAGApi.Core.Models
{
    public class ERPAGTaxRates
    {

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("taxBase")]
        public double TaxBase { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("tax")]
        public double Tax { get; set; }
    }
}
