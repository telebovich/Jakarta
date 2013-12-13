using System;
using NUnit.Framework;
using System.Web.Mvc;
using Jakarta;
using Jakarta.Controllers;
using Moq;

namespace Jakarta.Tests
{
	[TestFixture ()]
	public class BlogControllerTest
	{
		// [Test]
		// public void Index()
		// {
		// 	BlogController controller = new BlogController ();
		//	ViewResult result = controller.Index () as ViewResult;
		//	Assert.AreEqual ("Welcome to Blog!", result.ViewData ["Message"]);
		// }

		public Object _model;
		public BlogPost _exptected;
		// public Mock<IBlogPostRepository> _blogPostRepository;
		[SetUp]
		public void Setup()
		{
			// _expected = _blogPostRepository.GetById (1);
		}

		[Test]
		public void IndexShouldReturnBlogPost()
		{
			BlogController controller = new BlogController ();
			ViewResult result = controller.Index (1) as ViewResult;
			Assert.AreEqual ("Welcome to 1 Blog!", result.ViewData ["Message"]);
		}

		[Test]
		public void IndexShouldReturnModelOfTypeBlogPost()
		{
			var blogPostRepository = new Mock<IBlogPostRepository>();
			var blogPost = new BlogPost { Id = 1, 
				Title = "This is my mocked blog post", Copy = "This is my mocked blog post's copy",
				CreationDate = DateTime.Today, Content = "Bla-bla-bla", LikesCount = 3, 
				HeaderImageUrl = "~/headerImage.jpg"
			};

			blogPostRepository.Setup (b => b.GetById (1)).Returns (blogPost);
			BlogController controller = new BlogController ();
			var result = controller.Index () as ViewResult;

			var expected = blogPostRepository.Object.GetById (1);
			var actual = (BlogPost) result.ViewData.Model;
			Assert.AreEqual (expected, actual);
		}
	}
}

