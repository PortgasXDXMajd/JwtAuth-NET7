namespace JwtAuth.Models
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? RefreshToken { get; set; }
        public bool IsTokenActive { get; set; } = false;

        public Account()
        {
            this.Username = string.Empty;
            this.Password = string.Empty;
            this.RefreshToken = string.Empty;
        }
    }
}
