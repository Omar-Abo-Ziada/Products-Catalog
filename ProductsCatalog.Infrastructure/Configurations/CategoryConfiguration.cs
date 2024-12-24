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

            builder.HasIndex(x => x.Name).IsUnique(); // Ensure unique names

            //********************* Relations **************************

            builder.HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryID)
                .OnDelete(DeleteBehavior.SetNull);

            // ********************** Seeding Initial Data **********************

            builder.HasData(
                new Category { ID = 1, Name = "Electronics" },
                new Category { ID = 2, Name = "Books" },
                new Category { ID = 3, Name = "Clothing" },
                new Category { ID = 4, Name = "Home Appliances" },
                new Category { ID = 5, Name = "Sports Equipment" },
                new Category { ID = 6, Name = "Toys" },
                new Category { ID = 7, Name = "Furniture" },
                new Category { ID = 8, Name = "Beauty Products" },
                new Category { ID = 9, Name = "Stationery" },
                new Category { ID = 10, Name = "Groceries" }
            );
        }
    }
}