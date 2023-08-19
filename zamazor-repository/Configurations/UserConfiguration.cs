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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(d => new { d.Id, d.Email }).IsUnique();
            builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");
            builder.Property(x => x.Username).IsRequired().HasMaxLength(200);
            builder.ToTable("Users");
            builder.HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.RoleId);
        }
    }
}
