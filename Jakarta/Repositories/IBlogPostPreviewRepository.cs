using System;
using System.Collections.Generic;
using Jakarta.Models;

namespace Jakarta
{
	public interface IBlogPostPreviewRepository
	{
		PostPreview GetBlogPostPreview(int blogPostPreviewId);
		List<PostPreview> GetAllBlogPosts();
	}
}

