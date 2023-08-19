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
    public class CompanySeed : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Name = "Trendyol",
                    Email = "trendyol@trendyol.com",
                    PhoneNumber = "1234567890",
                    Address = "123 Trendyol"
                },
                new Company
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Name = "Hepsiburada",
                    Email = "hepsiburada@hepsiburada.com",
                    PhoneNumber = "9876543210",
                    Address = "456 Hepsiburada"
                }
            );
        }
    }
}
