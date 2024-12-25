using ProductsCatalog.Domain.DTOs.Products;
using ProductsCatalog.Domain.DTOs.Shared;
using ProductsCatalog.Domain.Entities;

namespace ProductsCatalog.Domain.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<ResultDTO> AddProductAsync(AddProductDTO addProductDTO, Guid userId);
    }
}