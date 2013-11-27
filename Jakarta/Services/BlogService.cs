using System;

namespace Jakarta
{
	public class BlogService: IBlogService 
	{
		public readonly IBlogPostPreviewRepository _blogPostPreviewRepository;
	}
}

