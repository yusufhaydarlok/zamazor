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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Teknoloji" },
                new Category { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Araba" },
                new Category { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Name = "Tekstil" }
            );
        }
    }
}
