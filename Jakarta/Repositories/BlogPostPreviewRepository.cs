using System;
using System.Collections.Generic;
using System.Linq;
using Jakarta.Models;

namespace Jakarta
{
	public class BlogPostPreviewRepository: IBlogPostPreviewRepository
	{
		private readonly IList<BlogPostPreviewItem> _blogPostPreviewList;

		public BlogPostPreviewItem GetBlogPostPreview(int blogPostPreviewId)
		{
			return _blogPostPreviewList
					.Where (bp => bp.Id == blogPostPreviewId)
					.FirstOrDefault ();
		}

		public BlogPostPreviewRepository()
		{
			_blogPostPreviewList = new List<BlogPostPreviewItem> {
				new BlogPostPreviewItem { Id = 1, Title = "First Post", PublishDate = DateTime.Now, 
					Copy = "This is my first post"
				},
				new BlogPostPreviewItem { Id = 2, Title = "Second Post", PublishDate = DateTime.Now, 
					Copy = "This is my second post"
				},
				new BlogPostPreviewItem { Id = 3, Title = "Third Post", PublishDate = DateTime.Now, 
					Copy = "This is my third post"
				},
				new BlogPostPreviewItem { Id = 4, Title = "Fourth Post", PublishDate = DateTime.Now, 
					Copy = "This is my fourth post"
				},
				new BlogPostPreviewItem { Id = 5, Title = "Fifth Post", PublishDate = DateTime.Now, 
					Copy = "This is my fifth post"
				}
			};
		}
		public List<BlogPostPreviewItem> GetAllBlogPosts()
		{
			var _previewList = new List<BlogPostPreviewItem> {
				new BlogPostPreviewItem { Id = 1, Title = "First Post", PublishDate = DateTime.Now, 
					Copy = "This is my first post"
				},
				new BlogPostPreviewItem { Id = 2, Title = "Second Post", PublishDate = DateTime.Now, 
					Copy = "This is my second post"
				},
				new BlogPostPreviewItem { Id = 3, Title = "Third Post", PublishDate = DateTime.Now, 
					Copy = "This is my third post"
				},
				new BlogPostPreviewItem { Id = 4, Title = "Fourth Post", PublishDate = DateTime.Now, 
					Copy = "This is my fourth post"
				},
				new BlogPostPreviewItem { Id = 5, Title = "Fifth Post", PublishDate = DateTime.Now, 
					Copy = "This is my fifth post"
				}
			};
			return _previewList;
		}
	}
}

