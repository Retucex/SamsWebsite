using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SamsWebsite.Controllers
{
    public class HomeController : Controller
    {
	    public ViewResult Index() => View();
	    public ViewResult Blog() => View();
	    public ViewResult Projects() => View();
	    public ViewResult About() => View();
    }
}
