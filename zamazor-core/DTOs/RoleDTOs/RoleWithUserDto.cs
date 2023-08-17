using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.UserDTOs;

namespace zamazor_core.DTOs.RoleDTOs
{
    public class RoleWithUsersDto : RoleDto
    {
        public List<UserDto> Users { get; set; }
    }
}
