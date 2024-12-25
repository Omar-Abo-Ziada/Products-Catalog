namespace ProductsCatalog.Domain.DTOs.Products
{
    public class ProductDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime StartDate { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        public bool CurrentTimeFiltered { get; set; }

        //***************** FKs & Navigations Props **********************

        //public Category Category { get; set; }
        public string CategoryName { get; set; }

        public int? CategoryID { get; set; }

        //---------------------------------------------------------------

        //public ApplicationUser CreatedBy { get; set; }
        public string CreatedByName { get; set; }

        public string CreatedByID { get; set; }

        //---------------------------------------------------------------

        //public ProductImage Image { get; set; }
        public string ImageUrl { get; set; }

        public int ImageID { get; set; }

        //---------------------------------------------------------------

        //public ICollection<ProductUpdateLog> ProductUpdateLogs { get; set; } = new HashSet<ProductUpdateLog>();
    }
}
