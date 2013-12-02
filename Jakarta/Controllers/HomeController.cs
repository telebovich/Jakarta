using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Jakarta.Models;
using Moq;

namespace Jakarta.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			List<PostPreview> posts = new List<PostPreview> ();
			ViewData ["Message"] = "Welcome to ASP.NET MVC on Mono!";

			var blogPostPreviewRepositoryMock = 
				new Mock<IBlogPostPreviewRepository> ();
			blogPostPreviewRepositoryMock
				.Setup (bp => bp.GetAllBlogPosts ());

			return View (posts);
		}
	}
}

