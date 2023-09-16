using Microsoft.AspNetCore.Identity;

namespace laba1.DAL
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] AvatarImage { get; set; }
        public string AvatarMimeType { get; set; }
    }
}
