using Microsoft.AspNetCore.Identity;

namespace Drive.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string MitarbeiterID { get; set; }
    }
}
