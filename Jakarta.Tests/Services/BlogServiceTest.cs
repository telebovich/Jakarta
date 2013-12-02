using System;
using NUnit.Framework;
using Ninject;
using Jakarta.Models;
using Moq;

namespace Jakarta.Tests
{
	[TestFixture]
	public class BlogServiceTest
	{
		[Test]
		public void ShouldBeAbleToGetBlogServiceFromNinject()
		{
			BlogService actual;
			var kernel = new StandardKernel (new CoreModule ());
			actual = kernel.Get<BlogService> ();
			Assert.IsNotNull (actual);
		}

		[Test]
		public void ShouldBeAbleToCallBlogPostServiceAndGetBlogPost()
		{
			var expected = new PostPreview { Id = 1, Title = "A Blog Post", 
				CreationDate = DateTime.Today, Copy = "This is a blog post" };
			var blogPostPreviewRepositoryMock = 
				new Mock<IBlogPostPreviewRepository> ();
			blogPostPreviewRepositoryMock
				.Setup (bp => bp.GetBlogPostPreview (1))
				.Returns (new PostPreview { Id = 1, Title = "A Blog Post", 
				CreationDate = DateTime.Today, Copy = "This is a blog post"
			});
			var blogPostPreviewService = 
				new BlogService (blogPostPreviewRepositoryMock.Object);
			var actual = blogPostPreviewService.GetBlogPostPreview (expected.Id);

			Assert.AreEqual (expected.Id, actual.Id);
			Assert.AreEqual (expected.Title, actual.Title);
			Assert.AreEqual (expected.CreationDate, actual.CreationDate);
			Assert.AreEqual (expected.Copy, actual.Copy);
		}
	}
}

