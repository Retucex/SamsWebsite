using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SamsWebsite.Models;

namespace SamsWebsite.Db
{
    public interface IBlogRepository
    {
		 IQueryable<BlogPost> BlogPosts { get; }
		 IQueryable<BlogComment> BlogComments { get; }
    }
}
