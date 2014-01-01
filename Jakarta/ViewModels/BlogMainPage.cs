using System;
using System.Collections.Generic;
using Jakarta.Models;

namespace Jakarta.ViewModels
{
	public class BlogMainPage
	{
		public List<BlogPostPreviewItem> MostReadItems = new List<BlogPostPreviewItem> ();
		public List<BlogPostPreviewItem> LatestItems = new List<BlogPostPreviewItem> ();
		public List<AccordeonPanelItem> AccordeonPanelItems = new List<AccordeonPanelItem>();

		void SetMostReadItemsList ()
		{
			MostReadItems.Add (new BlogPostPreviewItem {
				Id = 1,
				Title = "Lorem Ipsum",
				Image = "~/Content/images/demo2_small.jpg",
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " + "consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " + "Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today,
				Author = "Robert",
				CommentsCount = 3
			});
			MostReadItems.Add (new BlogPostPreviewItem {
				Id = 2,
				Title = "Ipsum Dolor",
				Image = "~/Content/images/demo3_small.jpg",
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " + "consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " + "Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today,
				Author = "Jake",
				CommentsCount = 2
			});
			MostReadItems.Add (new BlogPostPreviewItem {
				Id = 3,
				Title = "Dolor Sit Amet",
				Image = "~/Content/images/demo1_small.jpg",
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " + "consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " + "Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today,
				Author = "Jill",
				CommentsCount = 4
			});
		}

		void SetLatestItemsList ()
		{
			LatestItems.Add (new BlogPostPreviewItem {
				Id = 4,
				Title = "Lorem Ipsum",
				Image = "~/Content/images/thumb1.jpg",
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " + "consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " + "Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today,
				Author = "Robert",
				CommentsCount = 3
			});
			LatestItems.Add (new BlogPostPreviewItem {
				Id = 5,
				Title = "Lorem Ipsum",
				Image = "~/Content/images/thumb2.jpg",
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " + "consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " + "Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today,
				Author = "Robert",
				CommentsCount = 3
			});
			LatestItems.Add (new BlogPostPreviewItem {
				Id = 6,
				Title = "Lorem Ipsum",
				Image = "~/Content/images/pin2.jpg",
				Copy = "Vivamus tortor tellus, rutrum sit amet mollis vel, imperdiet " + "consectetur orci. Mauris pharetra congue enim, et sagittis lectus congue ut. " + "Cum sociis natoque penatibus.",
				PublishDate = DateTime.Today,
				Author = "Robert",
				CommentsCount = 3
			});
		}

		void SetAccordeonPanelItems()
		{
			AccordeonPanelItems.Add (new AccordeonPanelItem { Id = 1, Title = "Accordeon Panel Item 1", 
				Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod " +
				"tempor incididunt ut labore et dolore magna aliqua."
			});
			AccordeonPanelItems.Add (new AccordeonPanelItem { Id = 2, Title = "Accordeon Panel Item 2", 
				Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod " +
					"tempor incididunt ut labore et dolore magna aliqua."
			});
			AccordeonPanelItems.Add (new AccordeonPanelItem { Id = 3, Title = "Accordeon Panel Item 3", 
				Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod " +
					"tempor incididunt ut labore et dolore magna aliqua."
			});
		}

		public BlogMainPage ()
		{ 
			SetMostReadItemsList ();
			SetLatestItemsList ();
			SetAccordeonPanelItems ();
 		}
	}
}