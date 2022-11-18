using Microsoft.AspNetCore.Identity;

namespace GoogleKeepClone_DotNetAPI.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
