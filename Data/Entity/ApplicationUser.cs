using Microsoft.AspNetCore.Identity;

namespace LearnNet6.Data.Entity
{
    public class ApplicationUser :IdentityUser<Guid>
    {
        public string?  FirstName { get; set; }
        public string? LastName { get; set; }
        
        public  List<Post> Posts { get; set;}

    }

    public class ApplicationRole : IdentityRole<Guid>
    {

    }
}
