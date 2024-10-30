namespace ERPAGApi.Core.Models
{
    public class ERPAGCustomer
    {

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("customer")]
        public string CustomerData { get; set; }

        [JsonProperty("eMail")]
        public string EMail { get; set; }

        [JsonProperty("taxIdentificationNumber")]
        public string TaxIdentificationNumber { get; set; }

        [JsonProperty("termsOfPayment")]
        public string TermsOfPayment { get; set; }
    }
}
