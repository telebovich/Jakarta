using System;
using System.Collections.Generic;
using Jakarta.Models;

namespace Jakarta
{
	public class BlogPostRepository: IBlogPostRepository
	{
		public BlogPost GetById(int id)
		{
			return new BlogPost { Id = 1, Title = "This is my first blog post", 
				CreationDate = DateTime.Today, Excerpt = "This is my first copy"
					, Content = "Bla-bla-bla", LikesCount = 4
			};
		}
		public BlogPostRepository ()
		{
		}

		public List<BlogPost> GetAll()
		{
			var _list = new List<BlogPost> { 
				new BlogPost { Id = 1, Title = "This is my first blog post", 
					CreationDate = DateTime.Today, Excerpt = "Lorem ipsum dolor sit amet",
					Content = "Lorem ipsum dolor sit amet Lorem ipsum dolor sit amet",
					LikesCount = 4, HeaderImageUrl = "~/"
				},
				new BlogPost { Id = 1, Title = "This is my second blog post", 
					CreationDate = DateTime.Today, Excerpt = "Lorem ipsum dolor sit amet",
					Content = "Lorem ipsum dolor sit amet Lorem ipsum dolor sit amet",
					LikesCount = 4, HeaderImageUrl = "~/"
				},
				new BlogPost { Id = 1, Title = "This is my third blog post", 
					CreationDate = DateTime.Today, Excerpt = "Lorem ipsum dolor sit amet",
					Content = "Lorem ipsum dolor sit amet Lorem ipsum dolor sit amet",
					LikesCount = 4, HeaderImageUrl = "~/"
				}
			};
			return _list;
		}
	}
}

