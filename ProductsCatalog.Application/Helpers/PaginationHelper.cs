using ProductsCatalog.Domain.DTOs.Shared;

namespace ProductsCatalog.Application.Helpers
{
    public class PaginationHelper
    {
        public static PaginatedListDTO<T> Paginate<T>(IQueryable<T> source, int page, int pageSize)
        {
            var totalItems = source.Count();
            var paginatedItems = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedListDTO<T>(paginatedItems, totalItems, page, pageSize);
        }
        public static PaginatedListDTO<T> Paginate<T>(IEnumerable<T> source, int page, int pageSize)
        {
            var totalItems = source.Count();
            var paginatedItems = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return new PaginatedListDTO<T>(paginatedItems, totalItems, page, pageSize);
        }
        public static PaginationInfoDTO GetPaginationInfo<T>(PaginatedListDTO<T> paginatedList)
        {
            return new PaginationInfoDTO
            {
                TotalItems = paginatedList.TotalItems,
                TotalPages = paginatedList.TotalPages,
                CurrentPage = paginatedList.CurrentPage,
                StartPage = paginatedList.StartPage,
                EndPage = paginatedList.EndPage
            };
        }
    }
}