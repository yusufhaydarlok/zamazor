using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.UserDTOs;
using zamazor_core.DTOs;
using zamazor_core.Models;

namespace zamazor_core.Services
{
    public interface IUserService : IService<User, UserDto>
    {
        Task<CustomResponseDto<List<UserWithRoleDto>>> GetUsersWithRole();
    }
}
