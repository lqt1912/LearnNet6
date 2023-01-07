using System.ComponentModel.DataAnnotations;

namespace LearnNet6.Data.Entity
{
	public class MessageType
	{
		[Key]
		public int Id { get; set; }
		public string TypeName { get; set; }
		public string TypeAlias { get; set; }
		public long CreatedDate { get; set; }
		public long ModifiedDate { get; set; }

	}
}
