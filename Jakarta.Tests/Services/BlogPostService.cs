using System;
using Moq;
using NUnit.Framework;
using Jakarta.Models;

namespace Jakarta.Tests
{
	[TestFixture]
	public class BlogPostService
	{
		[Test]
		public void ShouldBeAbleToCallBlogPostServiceAndGetBlogPost ()
		{
			var expected = new BlogPost { Id = 1, Title = "This is my first post",
				CreationDate = DateTime.Today, Excerpt = "This is my first post's copy", 
				Content = "Bla-bla-bla", LikesCount = 4};
			var blogPostRepositoryMock = new Mock<IBlogPostRepository> ();
			blogPostRepositoryMock
				.Setup (bp => bp.GetById (1))
				.Returns(new BlogPost { Id = 1, Title = "This is my first post", 
					CreationDate = DateTime.Today, Excerpt = "This is my first post's copy",
					Content = "Bla-bla-bla", LikesCount = 4 });
			var blogPostService = new Jakarta.BlogPostService (blogPostRepositoryMock.Object);
			var actual = blogPostService.GetById (1);
		}
	}

	[TestFixture]
	public class BlogPostRepositoryTests
	{
		BlogPostRepository repository = new BlogPostRepository();

		[Test]
		public void ShouldReturnListOfBlogPosts()
		{
			var blog = repository.GetAll ();
			Assert.IsNotNull (blog);
		}
	}
}

