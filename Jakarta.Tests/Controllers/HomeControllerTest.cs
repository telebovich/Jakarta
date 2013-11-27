using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Jakarta;
using Jakarta.Controllers;
using Jakarta.Models;

namespace Jakarta.Tests
{
	[TestFixture ()]
	public class HomeControllerTest
	{
		[Test ()]
		public void Index ()
		{
			// Arrange
			HomeController controller = new HomeController ();

			// Act
			ViewResult result = controller.Index () as ViewResult;

			// Assert
			Assert.AreEqual ("Welcome to ASP.NET MVC on Mono!", result.ViewData ["Message"]);
		}

		[Test]
		public void IndexShouldReturnAtLeastOneNews()
		{
			PostPreview postPreview = new PostPreview ();
			Assert.IsInstanceOfType(typeof(int), postPreview.Id);
			Assert.IsNotNull (postPreview.Id);
			Assert.AreEqual ("This is my first post", postPreview.Title);
			Assert.AreEqual (DateTime.Today, postPreview.CreationDate);
			Assert.AreEqual ("This is my first post's copy?", postPreview.Copy);
		}

		[Test]
		public void ShouldBeAbleToAddCustomNews()
		{
			PostPreview postPreview = new PostPreview (1, "This is my custom post", DateTime.Today, "This is my custom post's copy?");
			Assert.IsInstanceOfType(typeof(int), postPreview.Id);
			Assert.IsNotNull (postPreview.Id);
			Assert.AreEqual ("This is my custom post", postPreview.Title);
			Assert.AreEqual (DateTime.Today, postPreview.CreationDate);
			Assert.AreEqual ("This is my custom post's copy?", postPreview.Copy);
		}
	}
}
