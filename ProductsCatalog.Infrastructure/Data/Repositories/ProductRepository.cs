using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Infrastructure.Data.Context;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}