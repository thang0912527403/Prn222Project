using Microsoft.AspNetCore.Identity;
using Prn222Project.Models;
using System.Security.Claims;
using System.Linq;
namespace Prn222Project.DataAccess
{
    public class ApplicationUserDASQLServer : IApplicationUserDA
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApplicationUserDASQLServer(UserManager<ApplicationUser> userManager,
                                         IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public List<ApplicationUser> GetAllUsers()
        {
            return _userManager.Users.ToList();
        }
        public ApplicationUser? GetUser()
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null) return null;
            return _userManager.Users.FirstOrDefault(u => u.Id == userId);
        }
        public async Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }
        public async Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user)
        {
            return await _userManager.GenerateEmailConfirmationTokenAsync(user);
        }
    } 
}
