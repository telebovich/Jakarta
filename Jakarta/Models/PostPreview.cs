using System;

namespace Jakarta.Models
{
	public class PostPreview
	{
		public string Title { get; set; }
		public DateTime CreationDate { get; set; }
		public string Copy { get; set; }

		public PostPreview ()
		{
			Title = "This is my first post";
			CreationDate = DateTime.Today;
			Copy = "This is my first post's copy?";
		}

		public PostPreview(string title, DateTime creationDate, string copy)
		{
			Title = title;
			CreationDate = creationDate;
			Copy = copy;
		}
	}
}

