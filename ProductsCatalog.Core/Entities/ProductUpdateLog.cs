namespace ProductsCatalog.Domain.Entities
{
    public class ProductUpdateLog
    {
        public int ID { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string Changes { get; set; }

        //***************** FKs & Navigations Props **********************

        public Product Product { get; set; }

        public int ProductID { get; set; }

        //---------------------------------------------------------------
        
        public string UpdatedBy { get; set; } 
    }
}