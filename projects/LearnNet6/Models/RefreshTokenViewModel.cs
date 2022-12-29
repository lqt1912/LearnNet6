namespace LearnNet6.Models
{
    public class RefreshTokenViewModel
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime? RevokedDate { get; set; }

        public bool IsActive
        {
            get
            {
                var isExpired = ExpiredDate < DateTime.UtcNow;
                var isRevoked = !RevokedDate.HasValue;
                return !isExpired && !isRevoked ;
            }
        }

        public bool IsExpired
        {
            get
            {
                return ExpiredDate < DateTime.UtcNow;
            }
        }
        public bool IsRevoked
        {
            get
            {
                return RevokedDate.HasValue;
            }
        }

    }
}
