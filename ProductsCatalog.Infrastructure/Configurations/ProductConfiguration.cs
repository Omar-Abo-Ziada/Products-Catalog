using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsCatalog.Domain;
using ProductsCatalog.Domain.Entities;

namespace ProductsCatalog.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Constants.MaxNameLength);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(Constants.MaxDescriptionLength);

            builder.Property(p => p.CreatedOn)
                   .IsRequired()
                   .HasDefaultValue(DateTime.Now);

            builder.Property(p => p.StartDate)
                .IsRequired();

            builder.Property(p => p.Duration)
                .IsRequired();

            builder.Property(p => p.CurrentTimeFiltered)
               .IsRequired();

            builder.Property(p => p.Price)
                   .HasPrecision(18, 2)
                   .IsRequired();

            //********************* Relations **************************

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryID).IsRequired(false).OnDelete(DeleteBehavior.SetNull); // this doesn't make the col nullable in db

            //builder.Property(p => p.CategoryID).IsRequired(false); // => need to explicitly mark the CategoryID property as nullable

            //---------------------------------------------------------

            builder.HasOne(p => p.CreatedBy)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.CreatedByID).IsRequired(false);

            //---------------------------------------------------------

            builder.HasOne(p => p.Image)
                         .WithOne(i => i.Product)
                         .HasForeignKey<ProductImage>(i => i.ProductID)
                         .IsRequired(false)
                         .OnDelete(DeleteBehavior.NoAction);

            //---------------------------------------------------------

            builder.HasMany(p => p.ProductUpdateLogs)
                .WithOne(l => l.Product)
                .HasForeignKey(l => l.ProductID)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}