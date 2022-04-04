using System.ComponentModel.DataAnnotations;

namespace LearnNet6.Data.Entity
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

    }
}
