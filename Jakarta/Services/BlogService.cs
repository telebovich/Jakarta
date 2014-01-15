using System;
using System.Collections.Generic;
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

		public BlogPostPreviewItem GetBlogPostPreview(int blogPostPreviewId)
		{
			return _blogPostPreviewRepository.GetBlogPostPreview(blogPostPreviewId);
		}

		public List<BlogPostPreviewItem> GetAllBlogPosts()
		{
			return _blogPostPreviewRepository.GetAll ();
		}
	}
}

