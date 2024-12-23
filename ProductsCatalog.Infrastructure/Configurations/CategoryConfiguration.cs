using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsCatalog.Domain;
using ProductsCatalog.Domain.Entities;

namespace ProductsCatalog.Infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Constants.MaxNameLength);

            builder.HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}