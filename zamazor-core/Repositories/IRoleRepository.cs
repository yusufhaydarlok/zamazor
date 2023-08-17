using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.Models;

namespace zamazor_core.Repositories
{
    public interface IRoleRepository : IGenericRepository<Role>
    {
        Task<Role> GetSingleRoleByIdWithUsersAsync(Guid roleId);
    }
}
