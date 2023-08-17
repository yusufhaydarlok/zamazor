using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.Models;

namespace zamazor_repository.Seeds
{
    public class ProductSaleConfiguration : IEntityTypeConfiguration<ProductSale>
    {
        public void Configure(EntityTypeBuilder<ProductSale> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.QuantitySold).IsRequired();
            builder.Property(x => x.SaleDate).IsRequired();
            builder.Property(x => x.UnitPrice).HasColumnType("decimal(18,2)");
            builder.Property(x => x.TotalProfit).HasColumnType("decimal(18,2)");
            builder.ToTable("ProductSales");
            builder.HasOne(x => x.SoldByUser).WithMany().HasForeignKey(x => x.SoldByUserId);
        }
    }
}
