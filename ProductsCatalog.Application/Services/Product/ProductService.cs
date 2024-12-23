using ProductsCatalog.Infrastructure.Data.Repositories;

namespace ProductsCatalog.Application.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
    }
}