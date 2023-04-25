using System.ComponentModel.DataAnnotations;

namespace LearnNet6.Data.Entity
{
	public class GroupMember
	{
		[Key]
		public int Id { get; set; }
		public Guid UserId { get; set; }
		public int GroupId { get; set; }
		public string UserRole { get; set; }
		public long CreatedDate { get; set; }
		public long ModifiedDate { get; set; }
	}
}
