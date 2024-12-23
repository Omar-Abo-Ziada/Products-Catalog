using ProductsCatalog.Domain;
using ProductsCatalog.Infrastructure.Data.Context;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}