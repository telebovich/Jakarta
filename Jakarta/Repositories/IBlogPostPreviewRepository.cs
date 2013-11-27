using System;
using Jakarta.Models;

namespace Jakarta
{
	public interface IBlogPostPreviewRepository
	{
		PostPreview GetBlogPostPreview(int blogPostPreviewId);
	}
}

