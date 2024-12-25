using AutoMapper;
using ProductsCatalog.Domain;
using ProductsCatalog.Domain.DTOs.Categories;
using ProductsCatalog.Domain.DTOs.Products;
using ProductsCatalog.Domain.Entities;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region Product Mappings

        CreateMap<Product, ProductDTO>()
           .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category != null ? src.Category.Name : string.Empty))
           .ForMember(dest => dest.CreatedByName, opt => opt.MapFrom(src => src.CreatedBy != null ? src.CreatedBy.FullName : string.Empty))
           .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Image != null ?
                                                   $"{src.Image.ImageUrl}" :
                                                   "https://apollobattery.com.au/wp-content/uploads/2022/08/default-product-image.png"));

        #endregion

        #region Category Mappings

        CreateMap<Category, CategoryDTO>();

        #endregion
    }
}
