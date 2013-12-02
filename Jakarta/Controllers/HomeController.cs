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
				.Setup (bp => bp.GetAllBlogPosts ())
				.Returns(new List<PostPreview> {
					new PostPreview { Id = 1, Title = "First Post", CreationDate = DateTime.Now, 
						Copy = "This is my first post"
					},
					new PostPreview { Id = 2, Title = "Second Post", CreationDate = DateTime.Now, 
						Copy = "This is my second post"
					},
					new PostPreview { Id = 3, Title = "Third Post", CreationDate = DateTime.Now, 
						Copy = "This is my third post"
					},
					new PostPreview { Id = 4, Title = "Fourth Post", CreationDate = DateTime.Now, 
						Copy = "This is my fourth post"
					},
					new PostPreview { Id = 5, Title = "Fifth Post", CreationDate = DateTime.Now, 
						Copy = "This is my fifth post"
					}
				});
			var blogPostPreviewService = new BlogService (blogPostPreviewRepositoryMock.Object);
			posts = blogPostPreviewService.GetAllBlogPosts ();
			return View (posts);
		}
	}
}

