using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.UserDTOs;
using zamazor_core.DTOs;

namespace zamazor_core.Services
{
    public interface IAuthService
    {
        Task<CustomResponseDto<UserDto>> Login(UserDto request);
        Task<CustomResponseDto<CreateUserDto>> Register(CreateUserDto request);
        Task<CustomResponseDto<string>> RefreshToken(string request);
    }
}
