using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.RoleDTOs;
using zamazor_core.DTOs;
using zamazor_core.Models;

namespace zamazor_core.Services
{
    public interface IRoleService : IService<Role, RoleDto>
    {
        Task<CustomResponseDto<RoleWithUsersDto>> GetSingleRoleByIdWithUsersAsync(Guid roleId);
    }
}
