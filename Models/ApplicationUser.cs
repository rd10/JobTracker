using Microsoft.AspNetCore.Identity;

namespace JobTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
