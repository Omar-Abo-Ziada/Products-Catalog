using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}