using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.RoleDTOs;

namespace zamazor_core.DTOs.UserDTOs
{
    public class UserWithRoleDto : UserDto
    {
        public RoleDto Role { get; set; }
    }
}
