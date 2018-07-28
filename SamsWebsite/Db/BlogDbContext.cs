using Microsoft.EntityFrameworkCore;
using SamsWebsite.Models;

namespace SamsWebsite.Db
{
	public class BlogDbContext : DbContext
	{
		public BlogDbContext(DbContextOptions<BlogDbContext> options)
			: base(options) { }

		public DbSet<BlogPost> BlogPosts { get; set; }
		public DbSet<BlogComment> BlogComments { get; set; }
	}
}