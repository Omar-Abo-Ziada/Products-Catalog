using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsCatalog.Domain.Entities;

namespace ProductsCatalog.Infrastructure.Configurations
{
    public class ProductUpdteLogsConfiguration : IEntityTypeConfiguration<ProductUpdateLog>
    {
        public void Configure(EntityTypeBuilder<ProductUpdateLog> builder)
        {
            builder.ToTable("ProductUpdateLogs");

            builder.HasKey(x => x.ID);

            builder.Property(l => l.UpdatedOn)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

            //********************* Relations **************************

            builder.HasOne(x => x.Product)
                .WithMany(p => p.ProductUpdateLogs)
                .HasForeignKey(x => x.ProductID).IsRequired().OnDelete(DeleteBehavior.NoAction);

            //---------------------------------------------------------

            builder.HasOne(x => x.UpdatedBy)
                .WithMany(u => u.productUpdateLogs)
                .HasForeignKey(x => x.UpdatedByID).IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
