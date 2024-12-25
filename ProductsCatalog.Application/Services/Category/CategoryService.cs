using AutoMapper;
using ProductsCatalog.Domain.DTOs.Categories;
using ProductsCatalog.Domain.DTOs.Products;
using ProductsCatalog.Domain.DTOs.Shared;
using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Application.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(ICategoryRepository categoryRepository , IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        //*********************************************************

        public async Task<CustomResponseDTO<List<CategoryDTO>>> GetAllCategoriesAsync()
        {
            try
            {
                // The Pagination List
                var allCategories = await categoryRepository.GetListAsync(
                    filter: null,
                    includes:null,
                    orderBy: query => query.OrderBy(x => x.Name),
                    asNoTracking: true
                    );

                if (allCategories is null || !allCategories.Any())
                {
                    return new CustomResponseDTO<List<CategoryDTO>>
                    {
                        Data = new List<CategoryDTO>(),
                        Message = "No Categories Found.",
                        Succeeded = true,
                        Errors = null,
                        PaginationInfo = null
                    };
                }

                var categoriesDTOs = mapper.Map<List<CategoryDTO>>(allCategories);

                return new CustomResponseDTO<List<CategoryDTO>>
                {
                    Data = categoriesDTOs,
                    Message = "Categories retrieved successfully.",
                    Succeeded = true,
                    Errors = null,
                    PaginationInfo = null
                };
            }
            catch (Exception ex)
            {
                return new CustomResponseDTO<List<CategoryDTO>>
                {
                    Data = new List<CategoryDTO>(),
                    Message = "An error occurred while retrieving categories.",
                    Succeeded = false,
                    Errors = new List<string> { ex.Message },
                    PaginationInfo = null
                };
            }
        }


    }
}