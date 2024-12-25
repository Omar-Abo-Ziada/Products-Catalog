using ProductsCatalog.Domain.DTOs.Categories;
using ProductsCatalog.Domain.DTOs.Shared;

namespace ProductsCatalog.Application.Services.Category
{
    public interface ICategoryService
    {
        public Task<CustomResponseDTO<List<CategoryDTO>>> GetAllCategoriesAsync();
    }
}