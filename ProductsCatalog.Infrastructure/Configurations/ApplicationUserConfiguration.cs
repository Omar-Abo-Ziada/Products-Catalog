using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsCatalog.Domain;
using System.Collections.Generic;

namespace ProductsCatalog.Infrastructure.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("ApplicationUsers");

            builder.Property(u => u.FirstName)
                  .IsRequired()
                  .HasMaxLength(Constants.MaxNameLength);

            builder.Property(u => u.LastName)
                  .IsRequired()
                  .HasMaxLength(Constants.MaxNameLength);

            builder.Property(u => u.Email)
                  .IsRequired()
                  .HasMaxLength(Constants.MaxEmailLength);

            //********************* Relations **************************

            builder.HasMany(u => u.Products)
                .WithOne(x => x.CreatedBy)
                .HasForeignKey(x => x.CreatedByID)
                .OnDelete(DeleteBehavior.SetNull);

            //---------------------------------------------------------

            builder.HasMany(u => u.productUpdateLogs)
                .WithOne(x => x.UpdatedBy)
                .HasForeignKey(x => x.UpdatedByID)
                .OnDelete(DeleteBehavior.NoAction);

            // *************** Seeding Initial Data **********************

            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                    new ApplicationUser
                    {
                        Id = "e8d727d7-27c8-4a68-8987-c4a45a9070f4", 
                        UserName = "omar@gmail.com",
                        NormalizedUserName = "OMAR@GMAIL.COM",
                        Email = "omar@gmail.com",
                        NormalizedEmail = "OMAR@GMAIL.COM",
                        FirstName = "Omar",
                        LastName = "Ahmed",
                        ConcurrencyStamp = "ae92b2cd-ec9f-4f13-b75d-0832fa0d6169",
                        PasswordHash = hasher.HashPassword(null, "Test@123"),
                        EmailConfirmed = true,
                    }
              );
        }
    }
}