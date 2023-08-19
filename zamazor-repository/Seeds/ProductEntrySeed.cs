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
    public class ProductEntrySeed : IEntityTypeConfiguration<ProductEntry>
    {
        public void Configure(EntityTypeBuilder<ProductEntry> builder)
        {
            builder.HasData(
                new ProductEntry
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    EntryDate = DateTime.Now.AddDays(-10),
                    Quantity = 100,
                    UnitPrice = 10.99m,
                    TotalCost = 1099.00m,
                    EnteredByUserId = Guid.NewGuid()
                },
                new ProductEntry
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    EntryDate = DateTime.Now.AddDays(-5),
                    Quantity = 50,
                    UnitPrice = 8.99m,
                    TotalCost = 449.50m,
                    EnteredByUserId = Guid.NewGuid()
                },
                new ProductEntry
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    EntryDate = DateTime.Now,
                    Quantity = 200,
                    UnitPrice = 12.49m,
                    TotalCost = 2498.00m,
                    EnteredByUserId = Guid.NewGuid()
                }
            );
        }
    }
}
