using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Prn222Project.Models;
using Prn222Project.Services;
using Prn222Project.ViewModels;
using System.Text;
using System.Text.Encodings.Web;
namespace Prn222Project.Controllers
{
    [Route("Authentication")]
    public class AuthenticationController : Controller
    {
        private readonly IApplicationUserServices _applicationUserServices;
        private readonly IEmailSender _emailSender;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AuthenticationController(IApplicationUserServices applicationUserServices,
            IEmailSender emailSender, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _applicationUserServices = applicationUserServices;
            _emailSender = emailSender;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(ViewModels.RegisterModel model)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Index", "Home");
            var result = await _applicationUserServices.RegisterUserAsync(model);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                var code = await _applicationUserServices.GenerateEmailConfirmationTokenAsync(user);
                var encodedCode = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Action(
                       "ConfirmEmail",
                       "Authentication",
                       new { userId = user.Id, code = encodedCode },
                       protocol: Request.Scheme);
                await _emailSender.SendEmailAsync(user.Email, "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                if (_userManager.Options.SignIn.RequireConfirmedAccount)
                {
                    return RedirectToAction("RegisterConfirmation", new { email = user.Email });
                }
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, error.Description);
            return View("~/Views/Home/Index.cshtml", model);
        }
        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
                return RedirectToAction("Index", "Home");
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return NotFound("User not found.");

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            TempData["NotificationComponent"] = "login";
            TempData["NotificationStatus"] = "success";
            TempData["NotificationMessage"] = "Xác thực email thành công. Bạn có thể bắt đầu đăng nhập ngay bây giờ.";
            return RedirectToAction("Index", "Home");
        }
        [HttpGet("RegisterConfirmation")]
        public IActionResult RegisterConfirmation(string email)
        {
            TempData["NotificationStatus"] = "success";
            TempData["NotificationMessage"] = "Đăng ký thành công! Check email của bạn để xác thực tài khoản của bạn và bắt đầu đăng nhập.";
            return RedirectToAction("Index", "Home");
        }
        [HttpGet("Login")]
        public async Task<IActionResult> Login()
        {
            
                TempData["NotificationComponent"] = "login";
                TempData["NotificationStatus"] = "error";
                TempData["NotificationMessage"] = "Bạn phải đăng nhập trước.";
            return RedirectToAction("Index", "Home");
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(ViewModels.LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["NotificationComponent"] = "login";
                TempData["NotificationStatus"] = "error";
                TempData["NotificationMessage"] = "Thông tin không hợp lệ.";
                return RedirectToAction("Index", "Home");
            }

            var result = await _applicationUserServices.SignInAsync(model.Email, model.Password);
            if (result.Succeeded)
            {
                TempData["NotificationStatus"] = "success";
                TempData["NotificationMessage"] = "Đăng nhập thành công.";
                return RedirectToAction("Index", "Home");
            }

            if (result.IsNotAllowed)
            {
                TempData["NotificationComponent"] = "login";
                TempData["NotificationStatus"] = "warning";
                TempData["NotificationMessage"] = "Bạn cần xác thực email trước khi đăng nhập.";
            }
            else
            {
                TempData["NotificationComponent"] = "login";
                TempData["NotificationStatus"] = "error";
                TempData["NotificationMessage"] = "Đăng nhập thất bại, kiểm tra lại tài khoản và mật khẩu.";
            }

            return RedirectToAction("Index", "Home");
        }
        [HttpGet("AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
