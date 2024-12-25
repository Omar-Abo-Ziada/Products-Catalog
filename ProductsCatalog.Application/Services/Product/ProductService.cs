using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProductsCatalog.Application.Helpers;
using ProductsCatalog.Domain.DTOs.Products;
using ProductsCatalog.Domain.DTOs.Shared;
using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Domain.Interfaces;
using System.Linq.Expressions;
using product = ProductsCatalog.Domain.Entities.Product;


namespace ProductsCatalog.Application.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        //************************************************

        public async Task<CustomResponseDTO<List<ProductDTO>>> GetAllProducts()
        {
            try
            {
                // The Pagination List
                var allProducts = await productRepository.GetListAsync(
                    filter: null,
                    includes:
                    [
                        query => query.Include(x => x.Category),
                        query => query.Include(x => x.CreatedBy),
                        query => query.Include(x => x.Image),
                    ],
                    orderBy: query => query.OrderBy(x => x.CreatedOn),
                    asNoTracking: true
                    );

                if (allProducts is null || !allProducts.Any())
                {
                    return new CustomResponseDTO<List<ProductDTO>>
                    {
                        Data = new List<ProductDTO>(),
                        Message = "No Products Found.",
                        Succeeded = true,
                        Errors = null,
                        PaginationInfo = null
                    };
                }

                var productsDTOs = mapper.Map<List<ProductDTO>>(allProducts);

                return new CustomResponseDTO<List<ProductDTO>>
                {
                    Data = productsDTOs,
                    Message = "Products retrieved successfully.",
                    Succeeded = true,
                    Errors = null,
                    PaginationInfo = null
                };
            }
            catch (Exception ex)
            {
                return new CustomResponseDTO<List<ProductDTO>>
                {
                    Data = new List<ProductDTO>(),
                    Message = "An error occurred while retrieving Products.",
                    Succeeded = false,
                    Errors = new List<string> { ex.Message },
                    PaginationInfo = null
                };
            }
        }

        public async Task<CustomResponseDTO<List<ProductDTO>>> GetProductsPaginatedFiltered(string userRole = "User", int page = 1, int pageSize = 5, int? categoryId = null)
        {
            try
            {
                Expression<Func<product, bool>> filter = d => true; // Default filter to return all products if didnt enter any condition

                if (userRole != "Admin")
                {
                    filter = categoryId != null && categoryId != 0
                        ? d => d.CategoryID == categoryId.Value && d.StartDate <= DateTime.Now && d.StartDate.AddDays(d.Duration) >= DateTime.Now
                        : d => d.StartDate <= DateTime.Now && d.StartDate.AddDays(d.Duration) >= DateTime.Now;
                }
                else if (categoryId != null && categoryId != 0)
                {
                    filter = d => d.CategoryID == categoryId.Value;
                }

                var paginatedProducts = await productRepository.GetPaginatedListAsync(
                    page: page,
                    pageSize: pageSize,
                    filter: filter,
                    includes: [
                        query => query.Include(d => d.Category),
                        query => query.Include(d => d.CreatedBy),
                        query => query.Include(d => d.Image),
                    ],
                    orderBy: query => query.OrderBy(x => x.CreatedOn),
                    isDescending: true,
                    asNoTracking: true
                );


                var paginationInfo = PaginationHelper.GetPaginationInfo(paginatedProducts);

                if (paginatedProducts is null || !paginatedProducts.Items.Any())
                {
                    return new CustomResponseDTO<List<ProductDTO>>
                    {
                        Data = new List<ProductDTO>(),
                        Message = "Np Products Found.",
                        Succeeded = false,
                        Errors = null,
                        PaginationInfo = null
                    };
                }

                var productsDTOs = mapper.Map<List<ProductDTO>>(paginatedProducts.Items);

                return new CustomResponseDTO<List<ProductDTO>>
                {
                    Data = productsDTOs,
                    Message = "Products retrieved successfully.",
                    Succeeded = true,
                    Errors = null,
                    PaginationInfo = paginationInfo
                };
            }
            catch (Exception ex)
            {
                return new CustomResponseDTO<List<ProductDTO>>
                {
                    Data = new List<ProductDTO>(),
                    Message = "An error occurred while retrieving Products.",
                    Succeeded = false,
                    Errors = new List<string> { ex.Message },
                    PaginationInfo = null
                };
            }
        }

        public async Task<CustomResponseDTO<ProductDTO>> GetProductById(int Id)
        {
            try
            {
                var product = await productRepository.
                    FindOneAsync(
                        filter: d => d.ID == Id,
                        includes:
                        [
                          query => query.Include(d => d.Category),
                          query => query.Include(d => d.CreatedBy),
                          query => query.Include(d => d.Image),
                        ]);

                if (product is null)
                {
                    return new CustomResponseDTO<ProductDTO>
                    {
                        Data = null,
                        Message = "Product Not Found.",
                        Succeeded = false,
                        Errors = null,
                        PaginationInfo = null
                    };
                }


                ProductDTO productDTO = mapper.Map<ProductDTO>(product);

                return new CustomResponseDTO<ProductDTO>
                {
                    Data = productDTO,
                    Message = "Product Retrieved Successfully.",
                    Succeeded = true,
                    Errors = null,
                    PaginationInfo = null
                };
            }
            catch (Exception ex)
            {
                return new CustomResponseDTO<ProductDTO>
                {
                    Data = null,
                    Message = "Error While Retrieving The Product.",
                    Succeeded = false,
                    Errors = new List<string> { ex.Message },
                    PaginationInfo = null
                };
            }
        }

        public async Task<CustomResponseDTO<ProductDTO>> AddProductAsync(AddProductDTO addProductDTO, Guid userId)
        {
            var result = await productRepository.AddProductAsync(addProductDTO, userId);

            return new CustomResponseDTO<ProductDTO>
            {
                Data = null,
                Message = result.Message,
                Succeeded = result.IsSuccess,
                Errors = result.IsSuccess ? null : new List<string> { result.Message },
                PaginationInfo = null
            };
        }
    }
}