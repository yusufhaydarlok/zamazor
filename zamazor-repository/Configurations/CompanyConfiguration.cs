using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.Models;

namespace zamazor_repository.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Email).HasMaxLength(200);
            builder.Property(x => x.PhoneNumber).HasMaxLength(20);
            builder.Property(x => x.Address).HasMaxLength(500);
            builder.ToTable("Companies");
            builder.HasMany(x => x.Users).WithOne(x => x.Company).HasForeignKey(x => x.CompanyId);
            builder.HasMany(x => x.Warehouses).WithOne(x => x.Company).HasForeignKey(x => x.CompanyId);
        }
    }
}
