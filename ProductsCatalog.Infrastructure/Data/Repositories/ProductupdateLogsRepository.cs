using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Domain.Interfaces;
using ProductsCatalog.Infrastructure.Data.Context;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class ProductupdateLogsRepository : GenericRepository<ProductUpdateLog>, IProductUpdateLogsRepository
    {
        public ProductupdateLogsRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}