namespace ERPAGApi.Core.Services
{
    public class ERPRAGProvider
    {
        public ERPRAGInvoiceService ERPAGInvoiceService;
        public ERPAGProductService ERPAGProductService;

        public ERPRAGProvider(string username, string password)
        {
            ERPAGInvoiceService = new ERPRAGInvoiceService(username, password);
            ERPAGProductService = new ERPAGProductService(username, password);

        }
    }
}
