using System;
using System.Collections.Generic;
using System.Linq;
using Jakarta.Models;

namespace Jakarta
{
	public class BlogPostPreviewRepository: IBlogPostPreviewRepository
	{
		private readonly IList<PostPreview> _blogPostPreviewList;

		public PostPreview GetBlogPostPreview(int blogPostPreviewId)
		{
			return _blogPostPreviewList
					.Where (bp => bp.Id == blogPostPreviewId)
					.FirstOrDefault ();
		}

		public BlogPostPreviewRepository()
		{
			_blogPostPreviewList = new List<PostPreview> {
				new PostPreview { Id = 1, Title = "First Post", CreationDate = DateTime.Now, 
					Copy = "This is my first post" },
				new PostPreview { Id = 2, Title = "Second Post", CreationDate = DateTime.Now, 
					Copy = "This is my second post" },
				new PostPreview { Id = 3, Title = "Third Post", CreationDate = DateTime.Now, 
					Copy = "This is my third post" },
				new PostPreview { Id = 4, Title = "Fourth Post", CreationDate = DateTime.Now, 
					Copy = "This is my fourth post" },
				new PostPreview { Id = 5, Title = "Fifth Post", CreationDate = DateTime.Now, 
					Copy = "This is my fifth post" }
			};
		}
	}
}

