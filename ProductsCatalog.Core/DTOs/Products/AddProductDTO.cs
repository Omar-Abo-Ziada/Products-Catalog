using Microsoft.AspNetCore.Http;

namespace ProductsCatalog.Domain.DTOs.Products
{
    public class AddProductDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        //***************** FKs & Navigations Props **********************

        public int? CategoryID { get; set; }

        //---------------------------------------------------------------

        public IFormFile Image { get; set; }

        //---------------------------------------------------------------

    }
}