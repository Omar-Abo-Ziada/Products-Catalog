using Microsoft.AspNetCore.Identity;
using ProductsCatalog.Domain.Entities;

namespace ProductsCatalog.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        //***************** FKs & Navigations Props **********************

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}