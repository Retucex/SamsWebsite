using System;

namespace SamsWebsite.Models
{
	public class BlogComment
	{
		public int BlogCommentID { get; set; }
		public string Author { get; set; }
		public string Comment { get; set; }
		public DateTime Published { get; set; }
		public BlogPost BlogPost { get; set; }
	}
}