namespace ERPAGApi.Parameters
{
    public class ERPAGQuery
    {
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public ERPAGQuery()
        {
        }

        public virtual IDictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> options = new Dictionary<string, string>();

            options.Add("dateStart", DateStart.ToString());
            options.Add("dateEnd", DateEnd.ToString());
            return options;
        }

    }
}
