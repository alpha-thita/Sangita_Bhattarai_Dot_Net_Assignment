using Microsoft.AspNetCore.Identity;

namespace OnlineStoreFurniture.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add any custom properties for the user here if needed
        // Example:
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}


