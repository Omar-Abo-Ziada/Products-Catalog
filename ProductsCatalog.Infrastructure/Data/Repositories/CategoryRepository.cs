using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Infrastructure.Data.Context;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}