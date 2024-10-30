namespace ERPAGApi.Core.Starter
{
    public class ConnexResponseHandler
    {
        public static T BuildResults<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data, ConnexSerialization.Settings);
        }
    }
}