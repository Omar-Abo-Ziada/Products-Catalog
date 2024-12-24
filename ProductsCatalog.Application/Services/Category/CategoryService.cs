using ProductsCatalog.Infrastructure.Data.Repositories;

namespace ProductsCatalog.Application.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
    }
}