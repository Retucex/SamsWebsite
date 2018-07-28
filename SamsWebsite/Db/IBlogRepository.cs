using System.Linq;
using SamsWebsite.Models;

namespace SamsWebsite.Db
{
	public interface IBlogRepository
	{
		IQueryable<BlogPost> BlogPosts { get; }
		IQueryable<BlogComment> BlogComments { get; }
	}
}