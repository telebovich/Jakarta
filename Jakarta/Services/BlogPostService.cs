using System;

namespace Jakarta
{
	public class BlogPostService: IBlogPostService 
	{
		public readonly IBlogPostRepository _blogPostRepository;

		public BlogPost GetById(int id)
		{
			return _blogPostRepository.GetById (id);
		}
			
		public BlogPostService (IBlogPostRepository blogPostRepository)
		{
			_blogPostRepository = blogPostRepository;
		}
	}
}

