using System.ComponentModel.DataAnnotations;

namespace LearnNet6.Data.Entity
{
	public class MessageItem
	{
		[Key]
		public int Id { get; set; }
		public int GroupId { get; set; }
		public Guid SenderId { get; set; }
		public string Content { get; set; }
		public string MediaContent { get; set; }
		public int MessageType { get; set; }
		public long CreatedDate { get; set; }
		public long ModifiedDate { get; set; }

	}
}
