using System;
using Jakarta.Models;

namespace Jakarta
{
	public class BlogPostRepository: IBlogPostRepository
	{
		public BlogPost GetById(int id)
		{
			return new BlogPost { Id = 1, Title = "This is my first blog post", 
				CreationDate = DateTime.Today, Copy = "This is my first copy"
					, Content = "Bla-bla-bla", LikesCount = 4
			};
		}
		public BlogPostRepository ()
		{
		}
	}
}

