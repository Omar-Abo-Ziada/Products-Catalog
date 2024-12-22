namespace ProductsCatalog.Domain.Entities
{
    public class ProductImage
    {
        public int ID { get; set; }

        public string ImageUrl { get; set; }

        public string FileName { get; set; }

        public long FileSize { get; set; }

        //***************** FKs & Navigations Props **********************

        public Product Product { get; set; }

        public int ProductID { get; set; }
    }
}