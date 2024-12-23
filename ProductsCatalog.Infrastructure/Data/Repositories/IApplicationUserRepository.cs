using ProductsCatalog.Domain;
using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public interface IApplicationUserRepository : IGenericRepository<ApplicationUser>
    {
    }
}