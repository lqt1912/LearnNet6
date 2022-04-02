using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnNet6.Data.Entity
{
    public class Post : BaseEntity
    {

        [MaxLength(100)]
        public string Title { get; set; }

        public Guid AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual ApplicationUser Author { get; set; }
    }
}

