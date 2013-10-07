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
			posts.Add (new PostPreview ("First post", DateTime.Today, "This is my first test"));
			posts.Add (new PostPreview ("Second post", DateTime.Today, "This is my second test"));
			posts.Add (new PostPreview ("Third post", DateTime.Today, "This is my third test"));
			posts.Add (new PostPreview ("Fourth post", DateTime.Today, "This is my fourth test"));
			posts.Add (new PostPreview ("Fifth post", DateTime.Today, "This is my fifth test"));

			ViewData ["Message"] = "Welcome to ASP.NET MVC on Mono!";
			return View (posts);
		}
	}
}

