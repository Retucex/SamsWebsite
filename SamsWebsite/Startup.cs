using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SamsWebsite.Db;

namespace SamsWebsite
{
    public class Startup
    {
	    public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration) => Configuration = configuration;

		public void ConfigureServices(IServiceCollection services)
        {
	        services.AddMvc();
	        //services.AddDbContext<BlogDbContext>(optionsBuilder => optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
	        services.AddTransient<IBlogRepository, FakeBlogRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
	        app.UseDeveloperExceptionPage();
	        app.UseStaticFiles();
	        app.UseStatusCodePages();
	        app.UseMvc(routes =>
	        {
		        routes.MapRoute("blog", "Blog/{blogPost:int?}", defaults: new {controller = "Home", action = "Blog"});
				routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
			});
        }
    }
}
