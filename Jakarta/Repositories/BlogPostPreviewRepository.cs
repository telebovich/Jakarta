using System;
using System.Collections.Generic;
using System.Linq;
using Jakarta.Models;

namespace Jakarta
{
	public class BlogPostPreviewRepository: IBlogPostPreviewRepository
	{
		private readonly IList<MostReadItem> _blogPostPreviewList;

		public MostReadItem GetBlogPostPreview(int blogPostPreviewId)
		{
			return _blogPostPreviewList
					.Where (bp => bp.Id == blogPostPreviewId)
					.FirstOrDefault ();
		}

		public BlogPostPreviewRepository()
		{
			_blogPostPreviewList = new List<MostReadItem> {
				new MostReadItem { Id = 1, Title = "First Post", PublishDate = DateTime.Now, 
					Copy = "This is my first post"
				},
				new MostReadItem { Id = 2, Title = "Second Post", PublishDate = DateTime.Now, 
					Copy = "This is my second post"
				},
				new MostReadItem { Id = 3, Title = "Third Post", PublishDate = DateTime.Now, 
					Copy = "This is my third post"
				},
				new MostReadItem { Id = 4, Title = "Fourth Post", PublishDate = DateTime.Now, 
					Copy = "This is my fourth post"
				},
				new MostReadItem { Id = 5, Title = "Fifth Post", PublishDate = DateTime.Now, 
					Copy = "This is my fifth post"
				}
			};
		}
		public List<MostReadItem> GetAllBlogPosts()
		{
			var _previewList = new List<MostReadItem> {
				new MostReadItem { Id = 1, Title = "First Post", PublishDate = DateTime.Now, 
					Copy = "This is my first post"
				},
				new MostReadItem { Id = 2, Title = "Second Post", PublishDate = DateTime.Now, 
					Copy = "This is my second post"
				},
				new MostReadItem { Id = 3, Title = "Third Post", PublishDate = DateTime.Now, 
					Copy = "This is my third post"
				},
				new MostReadItem { Id = 4, Title = "Fourth Post", PublishDate = DateTime.Now, 
					Copy = "This is my fourth post"
				},
				new MostReadItem { Id = 5, Title = "Fifth Post", PublishDate = DateTime.Now, 
					Copy = "This is my fifth post"
				}
			};
			return _previewList;
		}
	}
}

