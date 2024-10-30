namespace ERPAGApi.Core.Models
{
    public class ERPAGDefaultUom
    {

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("uom")]
        public string Uom { get; set; }
    }
}
