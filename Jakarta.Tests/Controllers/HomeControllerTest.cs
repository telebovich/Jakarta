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
		private HomeController controller;
		[SetUp]
		public void Setup()
		{
			controller = new HomeController ();
		}

		[Test ()]
		public void Index ()
		{
			// Arrange
			// HomeController controller = new HomeController ();

			// Act
			ViewResult result = controller.Index () as ViewResult;

			// Assert
			Assert.AreEqual ("Welcome to ASP.NET MVC on Mono!", result.ViewData ["Message"]);
		}

		[Test]
		public void IndexShouldReturnTypeOfListOfPostPreview()
		{
			ViewResult result = controller.Index () as ViewResult;
			Assert.IsInstanceOf (typeof(List<PostPreview>), result.Model);
		}
	}
}
