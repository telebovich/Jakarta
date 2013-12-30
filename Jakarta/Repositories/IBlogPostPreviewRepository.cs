using System;
using System.Collections.Generic;
using Jakarta.Models;

namespace Jakarta
{
	public interface IBlogPostPreviewRepository: IRepository 
	{
		MostReadItem GetBlogPostPreview(int blogPostPreviewId);
		List<MostReadItem> GetAllBlogPosts();
	}
}

