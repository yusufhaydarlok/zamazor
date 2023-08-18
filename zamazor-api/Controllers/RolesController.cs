using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zamazor_api.Filters;
using zamazor_core.DTOs.UserDTOs;
using zamazor_core.DTOs;
using zamazor_core.Models;
using zamazor_core.Services;
using zamazor_core.DTOs.RoleDTOs;

namespace zamazor_api.Controllers
{
    public class RolesController : CustomBaseController
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RolesController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleService.GetAllAsync();
            return CreateActionResult(CustomResponseDto<IEnumerable<RoleDto>>.Success(200, roles));
        }

        [HttpGet("[action]/{roleId}")]
        public async Task<IActionResult> GetSingleRoleByIdWithUsersAsync(Guid roleId)
        {
            return CreateActionResult(await _roleService.GetSingleRoleByIdWithUsersAsync(roleId));
        }
    }
}
