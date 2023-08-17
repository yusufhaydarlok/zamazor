using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.Models;
using zamazor_core.Repositories;

namespace zamazor_repository.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Role> GetSingleRoleByIdWithUsersAsync(Guid roleId)
        {
            return await _context.Roles.Include(x => x.Users).Where(x => x.Id == roleId).SingleOrDefaultAsync();
        }
    }
}
