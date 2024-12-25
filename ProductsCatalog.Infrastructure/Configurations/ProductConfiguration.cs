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
                .HasForeignKey(x => x.CategoryID).IsRequired(false).OnDelete(DeleteBehavior.SetNull); 

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

            // ****************** Seeding Initial Data *******************

            builder.HasData(
                // Electronics
                new Product { ID = 1, Name = "Smartphone", Description = "A high-tech smartphone with a powerful processor.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 30, Price = 499.99m, CurrentTimeFiltered = false, CategoryID = 1 },
                new Product { ID = 2, Name = "Laptop", Description = "A lightweight laptop for professionals.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 60, Price = 999.99m, CurrentTimeFiltered = true, CategoryID = 1 },
                new Product { ID = 3, Name = "Headphones", Description = "Wireless headphones with noise cancellation.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 45, Price = 199.99m, CurrentTimeFiltered = false, CategoryID = 1 },

                // Books
                new Product { ID = 4, Name = "Mystery Novel", Description = "A thrilling mystery novel.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 30, Price = 19.99m, CurrentTimeFiltered = false, CategoryID = 2 },
                new Product { ID = 5, Name = "Science Textbook", Description = "A comprehensive science textbook.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 45, Price = 49.99m, CurrentTimeFiltered = true, CategoryID = 2 },
                new Product { ID = 6, Name = "Cookbook", Description = "A cookbook with delicious recipes.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 60, Price = 29.99m, CurrentTimeFiltered = false, CategoryID = 2 },

                // Clothing
                new Product { ID = 7, Name = "T-shirt", Description = "A comfortable cotton T-shirt.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 15, Price = 9.99m, CurrentTimeFiltered = true, CategoryID = 3 },
                new Product { ID = 8, Name = "Jeans", Description = "Stylish and durable jeans.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 45, Price = 49.99m, CurrentTimeFiltered = false, CategoryID = 3 },
                new Product { ID = 9, Name = "Jacket", Description = "A warm winter jacket.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(3), Duration = 60, Price = 89.99m, CurrentTimeFiltered = true, CategoryID = 3 },

                // Home Appliances
                new Product { ID = 10, Name = "Microwave", Description = "A compact microwave oven.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 30, Price = 99.99m, CurrentTimeFiltered = false, CategoryID = 4 },
                new Product { ID = 11, Name = "Blender", Description = "A powerful kitchen blender.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 45, Price = 59.99m, CurrentTimeFiltered = false, CategoryID = 4 },
                new Product { ID = 12, Name = "Air Conditioner", Description = "Energy-efficient air conditioner.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(3), Duration = 60, Price = 299.99m, CurrentTimeFiltered = true, CategoryID = 4 },

                // Sports Equipment
                new Product { ID = 13, Name = "Football", Description = "A high-quality football for matches.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 30, Price = 25.99m, CurrentTimeFiltered = false, CategoryID = 5 },
                new Product { ID = 14, Name = "Tennis Racket", Description = "Lightweight and durable tennis racket.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 45, Price = 79.99m, CurrentTimeFiltered = false, CategoryID = 5 },
                new Product { ID = 15, Name = "Yoga Mat", Description = "A non-slip yoga mat for exercises.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(3), Duration = 60, Price = 19.99m, CurrentTimeFiltered = true, CategoryID = 5 },

                // Toys
                new Product { ID = 16, Name = "Action Figure", Description = "A collectible action figure for kids.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 30, Price = 14.99m, CurrentTimeFiltered = false, CategoryID = 6 },
                new Product { ID = 17, Name = "Lego Set", Description = "A creative building block set.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 45, Price = 49.99m, CurrentTimeFiltered = false, CategoryID = 6 },
                new Product { ID = 18, Name = "Board Game", Description = "A fun and engaging family board game.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(3), Duration = 60, Price = 29.99m, CurrentTimeFiltered = true, CategoryID = 6 },

                // Furniture
                new Product { ID = 19, Name = "Dining Table", Description = "A wooden dining table for six.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 30, Price = 299.99m, CurrentTimeFiltered = false, CategoryID = 7 },
                new Product { ID = 20, Name = "Office Chair", Description = "An ergonomic chair for office use.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 45, Price = 149.99m, CurrentTimeFiltered = false, CategoryID = 7 },
                new Product { ID = 21, Name = "Bookshelf", Description = "A spacious bookshelf for storage.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(3), Duration = 60, Price = 89.99m, CurrentTimeFiltered = true, CategoryID = 7 },

                // Beauty Products
                new Product { ID = 22, Name = "Lipstick", Description = "A long-lasting matte lipstick.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 30, Price = 14.99m, CurrentTimeFiltered = false, CategoryID = 8 },
                new Product { ID = 23, Name = "Moisturizer", Description = "A hydrating moisturizer for dry skin.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 45, Price = 24.99m, CurrentTimeFiltered = false, CategoryID = 8 },
                new Product { ID = 24, Name = "Perfume", Description = "A refreshing fragrance for daily use.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(3), Duration = 60, Price = 49.99m, CurrentTimeFiltered = true, CategoryID = 8 },

                // Stationery
                new Product { ID = 25, Name = "Notebook", Description = "A spiral notebook for taking notes.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 30, Price = 4.99m, CurrentTimeFiltered = false, CategoryID = 9 },
                new Product { ID = 26, Name = "Pen Set", Description = "A pack of 10 high-quality pens.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 45, Price = 9.99m, CurrentTimeFiltered = false, CategoryID = 9 },
                new Product { ID = 27, Name = "Planner", Description = "An organizer planner for daily tasks.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(3), Duration = 60, Price = 14.99m, CurrentTimeFiltered = true, CategoryID = 9 },

                // Groceries
                new Product { ID = 28, Name = "Rice", Description = "A 5kg pack of premium rice.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(1), Duration = 30, Price = 19.99m, CurrentTimeFiltered = false, CategoryID = 10 },
                new Product { ID = 29, Name = "Olive Oil", Description = "A bottle of extra virgin olive oil.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(2), Duration = 45, Price = 9.99m, CurrentTimeFiltered = false, CategoryID = 10 },
                new Product { ID = 30, Name = "Coffee Beans", Description = "A 1kg pack of Arabica coffee beans.", CreatedOn = DateTime.Now, StartDate = DateTime.Now.AddDays(3), Duration = 60, Price = 14.99m, CurrentTimeFiltered = true, CategoryID = 10 }
            );

        }
    }
}