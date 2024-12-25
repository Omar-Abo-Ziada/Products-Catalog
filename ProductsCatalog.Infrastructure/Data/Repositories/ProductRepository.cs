using Azure.Core;
using ProductsCatalog.Application.Helpers;
using ProductsCatalog.Domain;
using ProductsCatalog.Domain.DTOs.Products;
using ProductsCatalog.Domain.DTOs.Shared;
using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Domain.Interfaces;
using ProductsCatalog.Infrastructure.Data.Context;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDBContext context;

        public ProductRepository(ApplicationDBContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<ResultDTO> AddProductAsync(AddProductDTO addProductDTO , Guid userId)
        {
            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                    // 1. Create Product with null ImageId
                    var product = new Product
                    {
                        Name = addProductDTO.Name,
                        Description = addProductDTO.Description,
                        StartDate = addProductDTO.StartDate,
                        Duration = addProductDTO.Duration,
                        Price = addProductDTO.Price,
                        CategoryID = addProductDTO.CategoryID,
                        CreatedByID = userId.ToString(),
                        ImageID = null // ImageId will be updated later
                    };

                    context.Products.Add(product);
                    await context.SaveChangesAsync();  // Save product to get its ID

                    // 2. Handle image upload if provided
                    if (addProductDTO.Image != null)
                    {
                        // Validate image size
                        if (addProductDTO.Image.Length > Constants.MaxImageSize)
                        {
                            return ResultDTO.Failure("تعدى حجم الصور الحد الأقصى للصورة هو 1 ميجا بايت");
                        }

                        // Validate image extension
                        var extension = Path.GetExtension(addProductDTO.Image.FileName).ToLower();
                        if (!Constants.AllowedImageTypes.Contains(extension))
                        {
                            return ResultDTO.Failure("نوع الصورة غير مسموح به , يمكنك تحميل صورة من نوع png, jpg, jpeg");
                        }

                        // Generate a unique filename for the image
                        var fileName = $"{Path.GetFileNameWithoutExtension(addProductDTO.Image.FileName)}_{Guid.NewGuid()}";
                        var finalFileName = $"{fileName}{extension}";
                        var filePath = Path.Combine(Constants.ProductsImagesRealPath, finalFileName);

                        // Ensure the directory exists
                        if (!Directory.Exists(Constants.ProductsImagesRealPath))
                        {
                            Directory.CreateDirectory(Constants.ProductsImagesRealPath);
                        }

                        // Save the image file to the server
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await addProductDTO.Image.CopyToAsync(stream);
                        }

                        // 3. Create the ProductImage record
                        var productImage = new ProductImage
                        {
                            ImageUrl = $"/Images/Products/{finalFileName}",
                            FileName = finalFileName,
                            FileSize = addProductDTO.Image.Length,
                            ProductID = product.ID
                        };

                        context.ProductImages.Add(productImage);
                        await context.SaveChangesAsync();  // Save product and image records

                        product.ImageID = productImage.ID;

                        // 4. Save product and image together in one transaction
                        await context.SaveChangesAsync();  // Save product and image records

                    }

                    // Commit transaction if all operations are successful
                    await transaction.CommitAsync();
                    return ResultDTO.Success("تم اضافة المنتج بنجاح");
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return ResultDTO.Failure($"حدث خطأ {ex.Message}");
                }
            }
        }


    }
}