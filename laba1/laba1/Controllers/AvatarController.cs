using laba1.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace laba1.Controllers
{
    public class AvatarController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AvatarController(UserManager<ApplicationUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> GetAvatar()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user?.AvatarImage != null)
            {
                return File(user.AvatarImage, user.AvatarMimeType);
            }

            var avatarPath = Path.Combine(_webHostEnvironment.WebRootPath, "images", "default-avatar.png");
            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(avatarPath, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            return PhysicalFile(avatarPath, contentType);
        }
    }
}
