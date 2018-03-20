using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
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
		    return post == null
			    ? View(repository.BlogPosts
				    .Where(p => p.IsVisible))
			    : View("BlogPost", post);
	    }


	    public async Task<ViewResult> Projects()
	    {
		    using (var httpClient = new HttpClient())
		    {
			    httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0");
				httpClient.Timeout = TimeSpan.FromMinutes(2);

			    //TODO Figure out why GetStringAsync throws an HTTPException
				var response = await httpClient.GetStringAsync(new Uri("https://api.github.com/users/retucex/repos"));

			    var releases = JArray.Parse(response);

			    return View(releases.ToString());
			}
	    }

	    public ViewResult About() => View();
    }
}
