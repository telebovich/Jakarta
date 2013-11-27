using System;
using Jakarta.Models;

namespace Jakarta
{
	public interface IBlogService
	{
		PostPreview GetBlogPostPreview(int blogPostPreviewId);
	}
}

