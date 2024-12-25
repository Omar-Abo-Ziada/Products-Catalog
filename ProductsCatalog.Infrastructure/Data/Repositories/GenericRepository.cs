using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ProductsCatalog.Domain.DTOs.Shared;
using ProductsCatalog.Domain.Interfaces;
using ProductsCatalog.Infrastructure.Data.Context;
using System.Linq.Expressions;
using ProductsCatalog.Application.Helpers;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly ApplicationDBContext context;

        private readonly DbSet<T> dbSet;

        public GenericRepository(ApplicationDBContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        //**********************************

        public async Task<T?> FindByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<T?> FindOneAsync(
             Expression<Func<T, bool>> filter,
                 Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes = null,
                 Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                 bool asNoTracking = true)
            {
                IQueryable<T> query = dbSet;

                if (asNoTracking)
                {
                    query = query.AsNoTracking();
                }

                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        query = include(query);
                    }
                }

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                if (orderBy != null)
                {
                    return await orderBy(query).FirstOrDefaultAsync();
                }
                else
                {
                    return await query.FirstOrDefaultAsync();
                }
            }

        public async Task<List<T>> GetListAsync(
                Expression<Func<T, bool>> filter,
                Func<IQueryable<T>, IIncludableQueryable<T, object>>[] includes = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                bool asNoTracking = true)
            {
                IQueryable<T> query = dbSet;

                if (asNoTracking)
                {
                    query = query.AsNoTracking();
                }

                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        query = include(query);
                    }
                }

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                if (orderBy != null)
                {
                    query = orderBy(query);
                }

                return await query.ToListAsync();
            }

        public async Task<PaginatedListDTO<T>> GetPaginatedListAsync(
       Expression<Func<T, bool>>? filter = null,
       Func<IQueryable<T>, IIncludableQueryable<T, object>>[]? includes = null,
       Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
       bool asNoTracking = true,
       int page = 1,
       int pageSize = 10,
       bool isDescending = false) // Added isDescending parameter
        {
            IQueryable<T> query = dbSet;

            if (asNoTracking)
            {
                query = query.AsNoTracking();
            }

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = include(query);
                }
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Apply ordering based on isDescending flag
            if (orderBy != null)
            {
                query = orderBy(query);
            }

            // If isDescending is true, reverse the order by applying a descending order
            if (isDescending)
            {
                query = query.OrderByDescending(x => x); // This is a dummy placeholder; replace with a valid ordering field
            }

            int totalItems = await query.CountAsync();
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            page = Math.Clamp(page, 1, totalPages > 0 ? totalPages : 1);

            var items = await query.Skip((page - 1) * pageSize)
                                   .Take(pageSize)
                                   .ToListAsync();

            return new PaginatedListDTO<T>
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
                Items = items
            };
        }


        public async Task<ResultDTO> AddAsync(T entity)
        {
            if (entity == null)
                return ResultDTO.Failure("The entity to add cannot be null.");

            try
            {
                await dbSet.AddAsync(entity);
                await SaveAsync();
                return ResultDTO.Success("Entity added successfully.");
            }
            catch (Exception ex)
            {
                return ResultDTO.Failure($"An error occurred while adding the entity: {ex.Message}");
            }
        }

        public async Task<ResultDTO> AddRangeAsync(IEnumerable<T> entities)
        {
            if (entities == null || !entities.Any())
                return ResultDTO.Failure("The entities to add cannot be null or empty.");

            try
            {
                await dbSet.AddRangeAsync(entities);
                await SaveAsync();
                return ResultDTO.Success("Entities added successfully.");
            }
            catch (Exception ex)
            {
                return ResultDTO.Failure($"An error occurred while adding the entities: {ex.Message}");
            }
        }

        public async Task<ResultDTO> DeleteAsync(int id)
        {
            try
            {
                var entity = await dbSet.FindAsync(id);
                if (entity == null)
                    return ResultDTO.Failure($"Entity with ID {id} was not found.");

                dbSet.Remove(entity);
                await SaveAsync();
                return ResultDTO.Success("Entity deleted successfully.");
            }
            catch (Exception ex)
            {
                return ResultDTO.Failure($"An error occurred while deleting the entity: {ex.Message}");
            }
        }

        public async Task<ResultDTO> DeleteRangeAsync(IEnumerable<T> entities)
        {
            if (entities == null || !entities.Any())
                return ResultDTO.Failure("The list of entities to delete cannot be null or empty.");

            try
            {
                dbSet.RemoveRange(entities);
                await SaveAsync();
                return ResultDTO.Success("Entities deleted successfully.");
            }
            catch (Exception ex)
            {
                return ResultDTO.Failure($"An error occurred while deleting the entities: {ex.Message}");
            }
        }

        public async Task<ResultDTO> SaveAsync()
        {
            try
            {
                await context.SaveChangesAsync();
                return ResultDTO.Success("Changes saved successfully.");
            }
            catch (Exception ex)
            {
                return ResultDTO.Failure($"An error occurred while saving changes: {ex.Message}");
            }
        }
    }
}
