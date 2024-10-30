using ERPAGApi.Core.Services;
using ERPAGApi.Parameters;

namespace ERPAGApi.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ERPRAGProvider eRPRAGProvider = new ERPRAGProvider("userName", "password");

            var products = await eRPRAGProvider.ERPAGProductService.ListAsync(new ERPAGProductQuery()
            {
                DateStart = new DateTime(2020, 1, 1),
                DateEnd = DateTime.Now.AddDays(1)
            });

            foreach(var product in products) 
            { 
                Console.WriteLine(product.Sku);
            }

            var invoices = await eRPRAGProvider.ERPAGInvoiceService.ListAsync(new ERPAGQuery()
            {
                DateStart = new DateTime(2020, 1, 1),
                DateEnd = DateTime.Now.AddDays(1)
            });

            foreach(var invoice in invoices)
            {
                Console.WriteLine(invoice.Id);
            }

        }
    }
}