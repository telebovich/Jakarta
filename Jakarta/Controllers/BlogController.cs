using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using Jakarta.Models;

namespace Jakarta.Controllers
{
    public class BlogController : Controller
    {
		// public ActionResult Index()
		// {
		// 	ViewData ["Message"] = "Welcome to Blog!";
		//  return View ();
		// }

		public ActionResult Index(int id)
		{
			var blogPostRepositoryMock = new Mock<IBlogPostRepository>();
			blogPostRepositoryMock.Setup (bp => bp.GetById (1)).Returns (new BlogPost {
				Id = 1,
				Title = "Welcome to mocked blog!",
				CreationDate = DateTime.Today,
				Copy = "This is my mocked blog post's copy",
				Content = "Bla-bla-bla",
				LikesCount = 4,
				HeaderImageUrl = null
			});

			var blogPostService = new BlogPostService (blogPostRepositoryMock.Object);

			// ViewData ["Message"] = string.Format ("Welcome to {0} Blog!", id);
			return View (blogPostService.GetById(1));
		}
    }
}
