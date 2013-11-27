using System;
using NUnit.Framework;
using Ninject;

namespace Jakarta.Tests
{
	[TestFixture]
	public class BlogServiceTest
	{
		public void ShouldBeAbleToGetBlogServiceFromNinject()
		{
			BlogService actual;
			var kernel = new StandardKernel (new CoreModule ());
			actual = kernel.Get<BlogService> ();
			Assert.IsNotNull (actual);
		}
	}
}

