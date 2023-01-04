using JwtAuth.Infrastructure.Auth;
using JwtAuth.Models;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtService jwtService;
        public AuthController(IConfiguration iconfiguration, IJwtService _jwtService)
        {
            this.jwtService = _jwtService;
        }

        [HttpPost("login")]
        public ResponseModel<TokenDto> Login([FromBody] Account account)
        {
            if (account.Username.Equals("Majd") && account.Password.Equals("123456"))
            {
                return ResponseModel<TokenDto>.Success(jwtService.GenerateJWTTokens(account.Username));
            }
            else
            {
                return ResponseModel<TokenDto>.Fail(401, "username or password is wrong");
            }
        }
    }
}
