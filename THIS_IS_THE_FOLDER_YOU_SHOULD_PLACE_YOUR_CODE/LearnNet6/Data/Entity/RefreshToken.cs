using System.ComponentModel.DataAnnotations.Schema;

namespace LearnNet6.Data.Entity
{
    public class RefreshToken : BaseEntity
    {
        public string  Value { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime ExpiredDate { get; set; } = DateTime.UtcNow.AddDays(10);
        public DateTime? RevokedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}

