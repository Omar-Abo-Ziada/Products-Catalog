namespace ProductsCatalog.Domain.Entities
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        //***************** FKs & Navigations Props **********************

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}