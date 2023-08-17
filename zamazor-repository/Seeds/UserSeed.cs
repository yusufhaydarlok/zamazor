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
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
            new User { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Username = "yusufabi98", FirstName = "Yusuf Haydar", LastName = "Lök", Email = "yusufhaydarlok@gmail.com", PasswordHash = Encoding.UTF8.GetBytes("cokGizliSifre"), PasswordSalt = Encoding.UTF8.GetBytes("cokGizliSifre"), RoleId = Guid.NewGuid(), CompanyId = Guid.NewGuid() },
            new User { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Username = "nsungeu", FirstName = "Niyazi", LastName = "Sungurhan", Email = "niyazisungurhan@gmail.com", PasswordHash = Encoding.UTF8.GetBytes("akenoSenpai"), PasswordSalt = Encoding.UTF8.GetBytes("akenoSenpai"), RoleId = Guid.NewGuid(), CompanyId = Guid.NewGuid() },
            new User { Id = Guid.NewGuid(), CreatedDate = DateTime.Now, Username = "erenprlk", FirstName = "Eren", LastName = "Parlak", Email = "erenparlak@gmail.com", PasswordHash = Encoding.UTF8.GetBytes("balikciHasan"), PasswordSalt = Encoding.UTF8.GetBytes("balikciHasan"), RoleId = Guid.NewGuid(), CompanyId = Guid.NewGuid() }
            );
        }
    }
}
