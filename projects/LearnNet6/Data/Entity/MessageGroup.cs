using System.ComponentModel.DataAnnotations;

namespace LearnNet6.Data.Entity
{
	public class MessageGroup
	{
		[Key]
		public int Id { get; set; }
		public string GroupName { get; set; }
		public string GroupAlias { get; set; }
		public string AvatarUrl { get; set; }
		public long CreatedDate { get; set; }
		public long ModifiedDate { get; set; }

	}
}
