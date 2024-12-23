using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsCatalog.Domain;

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
        }
    }
}