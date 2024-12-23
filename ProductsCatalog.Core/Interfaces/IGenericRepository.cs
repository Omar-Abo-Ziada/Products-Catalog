using Microsoft.EntityFrameworkCore.Query;
using ProductsCatalog.Domain.DTOs.Shared;
using System.Linq.Expressions;

namespace ProductsCatalog.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T?> FindByIdAsync(int id);

        public Task<T?> FindOneAsync(
                 Expression<Func<T, bool>> filter,
                 Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes = null,
                 Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                 bool asNoTracking = true);

        public Task<List<T>> GetListAsync(
                Expression<Func<T, bool>> filter,
                Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                bool asNoTracking = true);

        public Task<PaginatedListDTO<T>> GetPaginatedListAsync(
                   Expression<Func<T, bool>>? filter = null,
                   Func<IQueryable<T>, IIncludableQueryable<T, object>>[]? includes = null,
                   Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                   bool asNoTracking = true,
                   int page = 1,
                   int pageSize = 10);

        public Task<ResultDTO> AddAsync(T entity);

        public Task<ResultDTO> AddRangeAsync(IEnumerable<T> entities);

        public Task<ResultDTO> DeleteAsync(int id);

        public Task<ResultDTO> DeleteRangeAsync(IEnumerable<T> entities);

        public Task<ResultDTO> SaveAsync();
    }
}