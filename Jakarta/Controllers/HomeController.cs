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
			List<MostReadItem> posts = new List<MostReadItem> ();
			ViewData ["Message"] = "Welcome to ASP.NET MVC on Mono!";

			var blogPostPreviewRepositoryMock = 
				new Mock<IBlogPostPreviewRepository> ();
			blogPostPreviewRepositoryMock
				.Setup (bp => bp.GetAllBlogPosts ())
				.Returns(new List<MostReadItem> {
					new MostReadItem { Id = 1, Title = "First Post", PublishDate = DateTime.Now, 
						Copy = "This is my first post"
					},
					new MostReadItem { Id = 2, Title = "Second Post", PublishDate = DateTime.Now, 
						Copy = "This is my second post"
					},
					new MostReadItem { Id = 3, Title = "Third Post", PublishDate = DateTime.Now, 
						Copy = "This is my third post"
					},
					new MostReadItem { Id = 4, Title = "Fourth Post", PublishDate = DateTime.Now, 
						Copy = "This is my fourth post"
					},
					new MostReadItem { Id = 5, Title = "Fifth Post", PublishDate = DateTime.Now, 
						Copy = "This is my fifth post"
					}
				});
			var blogPostPreviewService = new BlogService (blogPostPreviewRepositoryMock.Object);
			posts = blogPostPreviewService.GetAllBlogPosts ();
			return View ();
		}
	}
}