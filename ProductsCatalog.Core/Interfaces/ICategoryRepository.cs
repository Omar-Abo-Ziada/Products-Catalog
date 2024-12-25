using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Domain.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category> 
    {
    }
}