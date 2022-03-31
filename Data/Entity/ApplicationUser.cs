using Microsoft.AspNetCore.Identity;

namespace LearnNet6.Data.Entity
{
    public class ApplicationUser :IdentityUser
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }

    }
}
