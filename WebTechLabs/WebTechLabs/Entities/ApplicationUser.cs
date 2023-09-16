using Microsoft.AspNetCore.Identity;

namespace WebTechLabs.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[]? AvatarImage { get; set; }
        public string? AvatarMimeType { get; set; }
    }
}
