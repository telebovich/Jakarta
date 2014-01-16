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
			List<BlogPostPreviewItem> posts = new List<BlogPostPreviewItem> ();
			ViewData ["Message"] = "Welcome to ASP.NET MVC on Mono!";

			var blogPostPreviewRepositoryMock = 
				new Mock<IBlogPostPreviewRepository> ();
			blogPostPreviewRepositoryMock
				.Setup (bp => bp.GetAll ())
				.Returns(new List<BlogPostPreviewItem> {
					new BlogPostPreviewItem { Id = 1, Title = "First Post", PublishDate = DateTime.Now, 
						Copy = "This is my first post"
					},
					new BlogPostPreviewItem { Id = 2, Title = "Second Post", PublishDate = DateTime.Now, 
						Copy = "This is my second post"
					},
					new BlogPostPreviewItem { Id = 3, Title = "Third Post", PublishDate = DateTime.Now, 
						Copy = "This is my third post"
					},
					new BlogPostPreviewItem { Id = 4, Title = "Fourth Post", PublishDate = DateTime.Now, 
						Copy = "This is my fourth post"
					},
					new BlogPostPreviewItem { Id = 5, Title = "Fifth Post", PublishDate = DateTime.Now, 
						Copy = "This is my fifth post"
					}
				});
			var blogPostPreviewService = new BlogService (blogPostPreviewRepositoryMock.Object);
			posts = blogPostPreviewService.GetAllBlogPosts ();
			return View ();
		}

		public ActionResult About()
		{
			return View ();
		}

		public ActionResult Contacts()
		{
			return View ();
		}
	}
}