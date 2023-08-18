using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.RoleDTOs;
using zamazor_core.DTOs;
using zamazor_core.Models;
using zamazor_core.Repositories;
using zamazor_core.Services;
using zamazor_core.UnitOfWorks;

namespace zamazor_service.Services
{
    public class RoleService : Service<Role, RoleDto>, IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RoleService(IGenericRepository<Role> repository, IUnitOfWork unitOfWork, IMapper mapper, IRoleRepository roleRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
        }

        public async Task<CustomResponseDto<RoleWithUsersDto>> GetSingleRoleByIdWithUsersAsync(Guid roleId)
        {
            var role = await _roleRepository.GetSingleRoleByIdWithUsersAsync(roleId);
            var roleDto = _mapper.Map<RoleWithUsersDto>(role);
            return CustomResponseDto<RoleWithUsersDto>.Success(200, roleDto);
        }
    }
}
