namespace JwtAuth.Models
{
    public class TokenDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public TokenDto()
        {
            this.AccessToken = string.Empty;
            this.RefreshToken = string.Empty;
        }
        public TokenDto(string accessToken, string refreshToken)
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
        }
    }
}
