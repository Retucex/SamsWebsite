using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SamsWebsite.Db;

namespace SamsWebsite.Controllers
{
    public class HomeController : Controller
    {
	    IBlogRepository repository;

	    public HomeController(IBlogRepository repository) => this.repository = repository;

	    public ViewResult Index() => View();

	    public ViewResult Blog(int blogPost)
	    {
		    var post = repository.BlogPosts.SingleOrDefault(p => p.BlogPostID == blogPost);
		    return post == null ? View(repository.BlogPosts) : View("BlogPost", post);
	    }

	    public ViewResult Projects() => View();
	    public ViewResult About() => View();
    }
}
