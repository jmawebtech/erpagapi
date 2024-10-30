using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace ERPAGApi.Core.Models
{
    public class ERPAGInvoice
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
