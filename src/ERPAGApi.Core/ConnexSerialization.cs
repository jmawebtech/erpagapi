using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace ERPAGApi.Core.Starter
{
    public static class ConnexSerialization
    {
        static ConnexSerialization()
        {
            Settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateParseHandling = DateParseHandling.DateTimeOffset,
                DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind,
                Converters = new List<JsonConverter> {
                    new StringEnumConverter(){NamingStrategy = new CamelCaseNamingStrategy()}
                }
            };
        }

        public static JsonSerializerSettings Settings { get; set; }
    }
}