using System;
using System.Collections.Generic;
using System.Linq;
using Jakarta.Models;

namespace Jakarta
{
	public class BlogPostPreviewRepository
	{
		private readonly IList<PostPreview> _blogPostPreviewList;

		public PostPreview GetBlogPostPreview(int blogPostPreviewId)
		{
			return _blogPostPreviewList.Where (bp => bp.Id == blogPostPreviewId);
		}
	}
}

