using System;
using Jakarta.Models;

namespace Jakarta
{
	public class BlogService: IBlogService 
	{
		public readonly IBlogPostPreviewRepository _blogPostPreviewRepository;

		public BlogService(IBlogPostPreviewRepository blogPostPreviewRepository)
		{
			_blogPostPreviewRepository = blogPostPreviewRepository;
		}

		public PostPreview GetBlogPostPreview(int blogPostPreviewId)
		{
			return _blogPostPreviewRepository.GetBlogPostPreview(blogPostPreviewId);
		}
	}
}

