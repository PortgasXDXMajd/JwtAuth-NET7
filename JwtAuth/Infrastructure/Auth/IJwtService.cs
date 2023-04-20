using JwtAuth.Models;
using System.Security.Claims;

namespace JwtAuth.Infrastructure.Auth
{
    public interface IJwtService
    {
        TokenDto? GenerateJWTTokens(string userName);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}