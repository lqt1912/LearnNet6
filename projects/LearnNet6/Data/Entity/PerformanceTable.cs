using System.ComponentModel.DataAnnotations;

namespace LearnNet6.Data.Entity
{
    public class PerformanceTable
    {

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Note { get; set; }
    }
}
