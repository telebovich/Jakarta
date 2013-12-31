using System;
using NUnit.Framework;
using Jakarta.ViewModels;

namespace Jakarta.Tests
{
	[TestFixture]
	public class BlogMainPageTests
	{
		BlogMainPage blogMainPage = new BlogMainPage ();

		public BlogMainPageTests ()
		{
		}

		[Test]
		public void ShouldReturnaMostReadListObject()
		{
			Assert.IsNotNull (blogMainPage);
		}

		[Test]
		public void ShouldContainThreeMostReadItems()
		{
			Assert.AreEqual (3, blogMainPage.MostReadItems.Count); 
		}

		[Test]
		public void ShoulReturnLatestObject()
		{
			Assert.IsNotNull (blogMainPage.LatestItems);
		}

		[Test]
		public void ShouldReturnThreeLatestItems()
		{
			Assert.AreEqual (3, blogMainPage.LatestItems.Count);
		}
	}
}

