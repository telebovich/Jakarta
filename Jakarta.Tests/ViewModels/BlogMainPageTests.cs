using System;
using NUnit.Framework;
using Jakarta.ViewModels;

namespace Jakarta.Tests
{
	[TestFixture]
	public class BlogMainPageTests
	{
		public BlogMainPageTests ()
		{
		}

		[Test]
		public void BlogMainPageShouldReturnAnObject()
		{
			var blogMainPage = new BlogMainPage ();
			Assert.IsNotNull (blogMainPage);
		}

		[Test]
		public void BlogMainPageShouldContainThreeItems()
		{
			var blogMainPage = new BlogMainPage ();
			Assert.AreEqual (3, blogMainPage.MostReadItems.Count); 
		}
	}
}

