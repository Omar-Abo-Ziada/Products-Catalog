namespace ProductsCatalog.Application.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService categoryService;

        public CategoryService(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
    }
}