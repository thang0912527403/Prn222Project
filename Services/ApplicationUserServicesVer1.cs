using Microsoft.AspNetCore.Identity;
using Prn222Project.DataAccess;
using Prn222Project.Models;
using Prn222Project.ViewModels;
namespace Prn222Project.Services
{
    public class ApplicationUserServicesVer1 : IApplicationUserServices
    {
        private readonly IApplicationUserDA _applicationUserDA;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public ApplicationUserServicesVer1(IApplicationUserDA applicationUserDA, SignInManager<ApplicationUser> signInManager,
    UserManager<ApplicationUser> userManager)
        {
            _applicationUserDA = applicationUserDA;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public ApplicationUser? GetCurrentUser()
        {
            return _applicationUserDA.GetUser();
        }
        public List<ApplicationUser> GetAllUsers()
        {
            return _applicationUserDA.GetAllUsers();
        }
        public async Task<IdentityResult> RegisterUserAsync(RegisterModel model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                Name = model.FullName,
            };

            return await _applicationUserDA.CreateUserAsync(user, model.Password);
        }
        public async Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user)
        {
            return await _applicationUserDA.GenerateEmailConfirmationTokenAsync(user);
        }
        public async Task<SignInResult> SignInAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return SignInResult.Failed;
            if (!await _userManager.IsEmailConfirmedAsync(user))
                return SignInResult.NotAllowed;
            return await _signInManager.PasswordSignInAsync(user, password, false, lockoutOnFailure: false);
        }
    }
}
