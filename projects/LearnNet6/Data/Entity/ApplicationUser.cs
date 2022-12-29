using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnNet6.Data.Entity
{
    public class ApplicationUser :IdentityUser<Guid>
    {
        public string?  FirstName { get; set; }
        public string? LastName { get; set; }
        
        public virtual  List<Post> Posts { get; set;}
        public virtual List<RefreshToken> RefreshTokens { get; set; }
        public Guid? AddressId { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address? Address { get; set; }
    }

    public class ApplicationRole : IdentityRole<Guid>
    {

    }
}
