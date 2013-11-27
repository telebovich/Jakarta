using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Jakarta.Models;

namespace Jakarta.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			List<PostPreview> posts = new List<PostPreview> ();
			posts.Add (new PostPreview (1, "First post", DateTime.Today, "This is my first test"));
			posts.Add (new PostPreview (2, "Second post", DateTime.Today, "This is my second test"));
			posts.Add (new PostPreview (3, "Third post", DateTime.Today, "This is my third test"));
			posts.Add (new PostPreview (4, "Fourth post", DateTime.Today, "This is my fourth test"));
			posts.Add (new PostPreview (5, "Fifth post", DateTime.Today, "This is my fifth test"));

			ViewData ["Message"] = "Welcome to ASP.NET MVC on Mono!";
			return View (posts);
		}
	}
}

