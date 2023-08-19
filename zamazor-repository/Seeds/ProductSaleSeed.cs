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
    public class ProductSaleSeed : IEntityTypeConfiguration<ProductSale>
    {
        public void Configure(EntityTypeBuilder<ProductSale> builder)
        {
            builder.HasData(
                new ProductSale
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    SaleDate = DateTime.Now.AddDays(-10),
                    QuantitySold = 50,
                    UnitPrice = 15.99m,
                    TotalProfit = 400.00m,
                    SoldByUserId = Guid.NewGuid()
                },
                new ProductSale
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    SaleDate = DateTime.Now.AddDays(-5),
                    QuantitySold = 20,
                    UnitPrice = 12.49m,
                    TotalProfit = 200.00m,
                    SoldByUserId = Guid.NewGuid()
                },
                new ProductSale
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    SaleDate = DateTime.Now,
                    QuantitySold = 100,
                    UnitPrice = 9.99m,
                    TotalProfit = 800.00m,
                    SoldByUserId = Guid.NewGuid()
                }
            );
        }
    }

}
