using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamsWebsite.Models
{
    public class BlogPost
    {
	    static int excerptMaxLength = 120;

		public int BlogPostID { get; set; }
		public string Title { get; set; }
		public string Article { get; set; }

	    public string Excerpt
	    {
		    get
		    {
			    if (Article.Length < excerptMaxLength)
			    {
				    return Article;
			    }

			    return Article.Substring(0, excerptMaxLength);
		    }
	    }

	    public DateTime Published { get; set; }
		public List<BlogComment> Comments { get; set; }
    }
}
