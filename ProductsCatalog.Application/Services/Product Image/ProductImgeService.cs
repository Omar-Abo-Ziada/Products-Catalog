using ProductsCatalog.Infrastructure.Data.Repositories;

namespace ProductsCatalog.Application.Services.Product_Image
{
    public class ProductImgeService : IProductImgeService
    {
        private readonly IProductImageRepository productImageRepository;

        public ProductImgeService(IProductImageRepository productImageRepository)
        {
            this.productImageRepository = productImageRepository;
        }
    }
}
