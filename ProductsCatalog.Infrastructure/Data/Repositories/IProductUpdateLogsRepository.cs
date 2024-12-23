using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public interface IProductUpdateLogsRepository : IGenericRepository<ProductUpdateLog>
    {
    }
}
