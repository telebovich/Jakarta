using System;

namespace Jakarta.Models
{
	public class BlogPostPreviewItem
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Image { get; set; }
		public string Copy { get; set; }
		public DateTime PublishDate { get; set; }
		public string Author { get; set; }
		public int CommentsCount { get; set; }
	}
}

