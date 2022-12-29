using LearnNet6.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnNet6.Data.Entity
{
    public class NotificationToken
    {
        [Key]
        public Guid Id { get; set; }

        public string Value { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual AdUser User { get; set; }

    }
}
