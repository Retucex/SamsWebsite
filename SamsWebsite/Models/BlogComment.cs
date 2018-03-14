using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
