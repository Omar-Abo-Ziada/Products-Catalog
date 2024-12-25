using Microsoft.AspNetCore.Mvc;
using ProductsCatalog.Application.Helpers;
using ProductsCatalog.Application.Services.Category;
using ProductsCatalog.Application.Services.Product;
using ProductsCatalog.Domain.DTOs.Products;
using ProductsCatalog.Domain.DTOs.Shared;

namespace ProductsCatalog.Presentaion.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductController(IProductService productService , ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        //****************************************

        [HttpGet("All")]
        public async Task<ActionResult> All(int page = 1, int pageSize = 10)
        {
            CustomResponseDTO<List<ProductDTO>> response = await productService.GetAllProducts();
            //return response.Data;

            return View();
        }

        [HttpGet("AllPaginated")]
        public async Task<ActionResult> AllPaginated(int page = 1, int pageSize = 5)
        {
            var currentUserRole = ClaimsManager.GetRoles(User).FirstOrDefault();

            CustomResponseDTO<List<ProductDTO>> response = await productService.GetProductsPaginatedFiltered(currentUserRole,page, pageSize);
           
            var categories = await categoryService.GetAllCategoriesAsync();
            ViewBag.Categories = categories.Data;

            return View("AllProductsPaginated", response);
        }

        [HttpGet("AllPaginatedPartialFiltered")]
        public async Task<ActionResult> AllPaginatedPartialFiltered(int page = 1, int pageSize = 5 , int? categoryId = null)
        {
            var currentUserRole = ClaimsManager.GetRoles(User).FirstOrDefault();

            CustomResponseDTO<List<ProductDTO>> response = await productService.GetProductsPaginatedFiltered(currentUserRole,page, pageSize , categoryId);

            return PartialView("_ProductsPaginated", response);
        }

        [HttpGet("ID")]
        public async Task<CustomResponseDTO<ProductDTO>> GetDepartmentById(int id)
        {
            CustomResponseDTO<ProductDTO> response = await productService.GetProductById(id);
            return response;
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct([FromForm] AddProductDTO addProductDTO)
        {
            var userId = ClaimsManager.GetCurrentUserId(User);

            var result = await productService.AddProductAsync(addProductDTO, userId);

            if (result.Succeeded)
            {
                return Ok(new CustomResponseDTO<ProductDTO>
                {
                    Data = result.Data,  
                    Message = result.Message,
                    Succeeded = true,
                    Errors = null,
                    PaginationInfo = null
                });
            }

            return BadRequest(new CustomResponseDTO<ProductDTO>
            {
                Data = null,
                Message = result.Message,
                Succeeded = false,
                Errors =result.Errors,
                PaginationInfo = null
            });
        }


    }
}