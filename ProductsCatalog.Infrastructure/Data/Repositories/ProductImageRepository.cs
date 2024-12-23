using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Infrastructure.Data.Context;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}