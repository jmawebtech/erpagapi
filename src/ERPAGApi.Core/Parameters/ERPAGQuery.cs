namespace ERPAGApi.Parameters
{
    public class ERPAGProductQuery : ERPAGQuery
    {
        public string Category { get; set; } = string.Empty;

        public ERPAGProductQuery()
        {
        }

        public override IDictionary<string, string> ToDictionary()
        {

            IDictionary<string, string> options = base.ToDictionary();

            if (!String.IsNullOrEmpty(Category))
            {
                options.Add("category", Category);
            }

            return options;
        }

    }
}
