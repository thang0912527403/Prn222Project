using Microsoft.AspNetCore.Identity;
using Prn222Project.Models;
namespace Prn222Project.DataAccess
{
    public interface IApplicationUserDA
    {
        List<ApplicationUser> GetAllUsers();
        ApplicationUser? GetUser();
        Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password);
        Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user);
    }
}
