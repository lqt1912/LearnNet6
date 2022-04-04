using System.ComponentModel.DataAnnotations.Schema;

namespace LearnNet6.Data.Entity
{
    public class Address : BaseEntity
    {
        public string  District { get; set; }
        public string City { get; set; }
        public string  Detail { get; set; }
        public string Latitude { get; set; }
        public string  Longtitude { get; set; }
    }
}
