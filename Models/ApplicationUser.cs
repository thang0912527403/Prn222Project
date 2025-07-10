using Microsoft.AspNetCore.Identity;
namespace Prn222Project.Models
{
    public class ApplicationUser:IdentityUser
    {
        [PersonalData]
        public string? Name { get; set; }
        [PersonalData]
        public DateTime? DOB { get; set; }
        [PersonalData]
        public bool? Gender { get; set; }
        [PersonalData]
        public String? Address { get; set; }
    }
}
