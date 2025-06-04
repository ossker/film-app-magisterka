using Microsoft.AspNetCore.Identity;

namespace film_app_magisterka.Models.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
