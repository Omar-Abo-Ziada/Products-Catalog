using ProductsCatalog.Domain;
using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Domain.Interfaces
{
    public interface IApplicationUserRepository : IGenericRepository<ApplicationUser>
    {
    }
}