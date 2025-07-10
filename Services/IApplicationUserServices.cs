using Microsoft.AspNetCore.Identity;
using Prn222Project.Models;
using Prn222Project.ViewModels;
namespace Prn222Project.Services
{
    public interface IApplicationUserServices
    {
        ApplicationUser? GetCurrentUser();
        List<ApplicationUser> GetAllUsers();
        Task<IdentityResult> RegisterUserAsync(RegisterModel model);
        Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user);
        Task<SignInResult> SignInAsync(string email, string password);
    }
}
