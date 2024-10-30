namespace ERPAGApi.Core.Services
{
    public class ERPRAGInvoiceService : StarterService
    {
        public ERPRAGInvoiceService(string username, string password) : base(username, password, ERPAGConstants.ProductionUrl)
        {

        }

        public async Task<ERPAGSalesOrder> ListByIdAsync(string id)
        {
            return await ListAsync<ERPAGSalesOrder>("salesorder?id=" + id, new Dictionary<string, string>());
        }

        public async Task<List<string>> ListByInvoiceNumberAsync(string id)
        {
            return await ListAsync<List<string>>("get_invoice_by_number?invoiceNumber=" + id, new Dictionary<string, string>());
        }

        public async Task<List<ERPAGInvoice>> ListAsync(ERPAGQuery query)
        {
            return await ListAsync<List<ERPAGInvoice>>("get_so_invoices_by_date", query.ToDictionary());
        }
    }
}

