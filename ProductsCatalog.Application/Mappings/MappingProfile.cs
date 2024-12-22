using AutoMapper;
using ProductsCatalog.Domain.Entities;
using ProductsCatalog.Infrastructure;

namespace ProductsCatalog.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, User>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName));

            CreateMap<User, ApplicationUser>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.FullName));
        }
    }
}