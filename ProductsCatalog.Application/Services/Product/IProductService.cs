using ProductsCatalog.Domain.DTOs.Products;
using ProductsCatalog.Domain.DTOs.Shared;

namespace ProductsCatalog.Application.Services.Product
{
    public interface IProductService
    {
        public Task<CustomResponseDTO<List<ProductDTO>>> GetAllProducts();

        public Task<CustomResponseDTO<List<ProductDTO>>> GetProductsPaginatedFiltered(string userRole = "User" ,int page = 1, int pageSize = 5, int? categoryId = null);

        public Task<CustomResponseDTO<ProductDTO>> GetProductById(int Id);

        public Task<CustomResponseDTO<ProductDTO>> AddProductAsync(AddProductDTO addProductDTO , Guid userId);
    }
}