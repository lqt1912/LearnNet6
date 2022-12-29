using System.ComponentModel.DataAnnotations;

namespace LearnNet6.Data.Entity
{
    public class PerfomanceObject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Value { get; set; }
        public string  Note { get; set; }
    }
}
