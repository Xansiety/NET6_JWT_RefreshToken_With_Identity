using Microsoft.AspNetCore.Identity;

namespace NET6_JWT_RefreshToken_With_Identity.Entidades.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
