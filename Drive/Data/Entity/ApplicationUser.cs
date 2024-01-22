using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Drive.Data.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string MitarbeiterID { get; set; }
        public ICollection<Tours> Tours { get; set; }
    }
}
