using System;
using System.Collections.Generic;
using Jakarta.Models;

namespace Jakarta.ViewModels
{
	public class BlogMainPage
	{
		public List<BlogPostPreviewItem> MostReadItems = new List<BlogPostPreviewItem> ();
		public List<BlogPostPreviewItem> LatestItems = new List<BlogPostPreviewItem> ();

		public BlogMainPage ()
		{ 
			MostReadItems.Add (new BlogPostPreviewItem { Id = 1, Title = "Lorem Ipsum", 
				Image = "~/Content/images/demo2_small.jpg", 
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " +
					"consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " +
					"Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today, Author = "Robert", CommentsCount = 3
			});
			MostReadItems.Add (new BlogPostPreviewItem { Id = 2, Title = "Ipsum Dolor", 
				Image = "~/Content/images/demo3_small.jpg",
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " +
					"consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " +
					"Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today, Author = "Jake", CommentsCount = 2
			});
			MostReadItems.Add (new BlogPostPreviewItem { Id = 3, Title = "Dolor Sit Amet", 
				Image = "~/Content/images/demo1_small.jpg",
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " +
					"consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " +
					"Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today, Author = "Jill", CommentsCount = 4
			});
			LatestItems.Add (new BlogPostPreviewItem { Id = 4, Title = "Lorem Ipsum", 
				Image = "~/Content/images/thumb1.jpg", 
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " +
					"consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " +
					"Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today, Author = "Robert", CommentsCount = 3
			});
			LatestItems.Add (new BlogPostPreviewItem { Id = 5, Title = "Lorem Ipsum", 
				Image = "~/Content/images/thumb2.jpg", 
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " +
					"consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " +
					"Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today, Author = "Robert", CommentsCount = 3
			});
			LatestItems.Add (new BlogPostPreviewItem { Id = 6, Title = "Lorem Ipsum", 
				Image = "~/Content/images/pin2.jpg", 
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " +
					"consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " +
					"Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today, Author = "Robert", CommentsCount = 3
			});
 		}
	}
}