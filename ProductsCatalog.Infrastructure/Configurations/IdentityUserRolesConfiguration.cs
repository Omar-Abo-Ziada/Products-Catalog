using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductsCatalog.Infrastructure.Configurations
{
    public class IdentityUserRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            // Seed user-roles data

            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "e8d727d7-27c8-4a68-8987-c4a45a9070f4", // Omar
                    RoleId = "952625cb-623b-4f8e-a426-c9e14ffe41bc" // Admin Role ID
                }
            );
        }
    }
}