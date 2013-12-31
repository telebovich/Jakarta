using System;
using System.Collections.Generic;
using Jakarta.Models;

namespace Jakarta
{
	public interface IBlogPostPreviewRepository: IRepository 
	{
		BlogPostPreviewItem GetBlogPostPreview(int blogPostPreviewId);
		List<BlogPostPreviewItem> GetAllBlogPosts();
	}
}

