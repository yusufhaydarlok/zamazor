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
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    ProductName = "Smartphone",
                    StockCode = "SPH123",
                    PurchasePrice = 300.00m,
                    SalePrice = 450.00m,
                    SupplierId = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid()
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    ProductName = "Laptop",
                    StockCode = "LTP456",
                    PurchasePrice = 800.00m,
                    SalePrice = 1100.00m,
                    SupplierId = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid()
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    ProductName = "T-Shirt",
                    StockCode = "TSH789",
                    PurchasePrice = 10.00m,
                    SalePrice = 20.00m,
                    SupplierId = Guid.NewGuid(),
                    CategoryId = Guid.NewGuid()
                }
            );
        }
    }

}
