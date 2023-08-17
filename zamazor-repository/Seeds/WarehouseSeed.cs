using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.Models;
using System.ComponentModel.Design;

namespace zamazor_repository.Seeds
{
    public class WarehouseSeed : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.HasData(
            new Warehouse { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Main Warehouse", CompanyId = Guid.NewGuid() },
            new Warehouse { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Main Warehouse", CompanyId = Guid.NewGuid() }
            );
        }
    }
}
