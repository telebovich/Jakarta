using System;
using NUnit.Framework;
using System.Web.Mvc;
using Jakarta;
using Jakarta.Controllers;

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

		[Test]
		public void IndexShouldReturnBlogPost()
		{
			BlogController controller = new BlogController ();
			ViewResult result = controller.Index (1) as ViewResult;
			Assert.AreEqual ("Welcome to 1 Blog!", result.ViewData ["Message"]);
		}
	}
}

