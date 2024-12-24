using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsCatalog.Domain;
using ProductsCatalog.Domain.Entities;

namespace ProductsCatalog.Infrastructure.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductsImages");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.ImageUrl)
                .IsRequired()
                .HasMaxLength(Constants.MaxImageUrlLength);

            builder.Property(x => x.FileName)
                .IsRequired()
                .HasMaxLength(Constants.MaxNameLength);

            builder.Property(x => x.FileSize)
                .IsRequired()
                .HasMaxLength(Constants.MaxFileSizeLength);

            //********************* Relations **************************

            builder.HasOne(x => x.Product)
                .WithOne(x => x.Image)
                .HasForeignKey<Product>(x => x.ImageID).IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}