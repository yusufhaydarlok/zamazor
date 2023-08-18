using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zamazor_api.Filters;
using zamazor_core.DTOs.UserDTOs;
using zamazor_core.DTOs;
using zamazor_core.Models;
using zamazor_core.Services;
using zamazor_core.DTOs.ProductDTOs;

namespace zamazor_api.Controllers
{
    public class UsersController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _service;

        public UsersController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _service = userService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetUsersWithRole()
        {
            return CreateActionResult(await _service.GetUsersWithRole());
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var usersDto = await _service.GetAllAsync();
            return CreateActionResult(CustomResponseDto<IEnumerable<UserDto>>.Success(200, usersDto));
        }

        [ServiceFilter(typeof(NotFoundFilter<Product>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var userDto = await _service.GetByIdAsync(id);
            return CreateActionResult(CustomResponseDto<UserDto>.Success(200, userDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CreateUserDto createUserDto)
        {
            var user = await _service.AddAsync(_mapper.Map<User>(createUserDto));
            return CreateActionResult(CustomResponseDto<UserDto>.Success(201, user));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserDto updateUserDto)
        {
            await _service.UpdateAsync(_mapper.Map<User>(updateUserDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var user = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(_mapper.Map<User>(user));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
