using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.UserDTOs;
using zamazor_core.DTOs;
using zamazor_core.Models;
using zamazor_core.Repositories;
using zamazor_core.Services;
using zamazor_service.Utilities;
using Microsoft.EntityFrameworkCore;

namespace zamazor_service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IGenericRepository<User> _repository;
        private readonly JwtUtils _jwtUtils;

        public AuthService(IMapper mapper, IGenericRepository<User> repository, IUserService userService, JwtUtils jwtUtils)
        {
            _mapper = mapper;
            _repository = repository;
            _userService = userService;
            _jwtUtils = jwtUtils;
        }

        public async Task<CustomResponseDto<UserDto>> Login(UserDto request)
        {
            var user = (await _repository.Where(x => x.Username == request.Username).ToListAsync()).FirstOrDefault();

            if (user == null)
            {
                return CustomResponseDto<UserDto>.Fail(404, "User not found.");
            }

            if (!_jwtUtils.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return CustomResponseDto<UserDto>.Fail(204, "Wrong password.");
            }

            var token = _jwtUtils.CreateToken(user);
            var refreshToken = _jwtUtils.GenerateRefreshToken();
            HttpResponse httpResponse = null;
            _jwtUtils.SetRefreshToken(refreshToken, httpResponse);
            return CustomResponseDto<UserDto>.Success(200, _mapper.Map<UserDto>(token));
        }


        public async Task<CustomResponseDto<string>> RefreshToken(string request)
        {
            HttpRequest httpRequest = null;
            HttpResponse httpResponse = null;

            var userId = _jwtUtils.GetMyId();
            var user = await _repository.GetByIdAsync(Guid.Parse(userId));
            var refreshToken = httpRequest.Cookies["refreshToken"];

            if (!user.RefreshToken.Equals(refreshToken))
            {
                return CustomResponseDto<string>.Fail(401, "Invalid Refresh Token.");
            }
            else if (user.TokenExpires < DateTime.Now)
            {
                return CustomResponseDto<string>.Fail(401, "Token expired.");
            }

            string token = _jwtUtils.CreateToken(user);
            var newRefreshToken = _jwtUtils.GenerateRefreshToken();
            _jwtUtils.SetRefreshToken(newRefreshToken, httpResponse);
            return CustomResponseDto<string>.Success(200, token);
        }

        public async Task<CustomResponseDto<CreateUserDto>> Register(CreateUserDto request)
        {
            _jwtUtils.CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
            User user = _mapper.Map<User>(request);
            user.Username = request.Username;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            await _userService.AddAsync(user);
            var userDto = _mapper.Map<UserDto>(user);
            return CustomResponseDto<CreateUserDto>.Success(201, request);
        }
    }
}
