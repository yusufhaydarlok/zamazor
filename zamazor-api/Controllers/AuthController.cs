using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zamazor_core.DTOs.UserDTOs;
using zamazor_core.Services;

namespace zamazor_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : CustomBaseController
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public AuthController(IConfiguration configuration, IAuthService authService, IMapper mapper)
        {
            _configuration = configuration;
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(CreateUserDto request)
        {
            var result = await _authService.Register(request);
            return CreateActionResult(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto request)
        {
            var result = await _authService.Login(request);
            return CreateActionResult(result);
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken(string request)
        {
            var result = await _authService.RefreshToken(request);
            return CreateActionResult(result);
        }
    }
}
