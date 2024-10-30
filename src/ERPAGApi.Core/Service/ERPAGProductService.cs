
namespace ERPAGApi.Core.Services
{
    public class ERPAGProductService : StarterService
    {
        public ERPAGProductService(string username, string password) : base(username, password, ERPAGConstants.ProductionUrl)
        {

        }

        public async Task<List<ERPAGProduct>> ListAsync(ERPAGProductQuery query)
        {
            return await ListAsync<List<ERPAGProduct>>("get_products_by_date", query.ToDictionary());
        }
    }
}

