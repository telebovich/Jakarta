using System;

namespace Jakarta.Models
{
	public class PostPreview
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime CreationDate { get; set; }
		public string Copy { get; set; }

		public PostPreview ()
		{
			Title = "This is my first post";
			CreationDate = DateTime.Today;
			Copy = "This is my first post's copy?";
		}

		public PostPreview(int id, string title, DateTime creationDate, string copy)
		{
			Id = id;
			Title = title;
			CreationDate = creationDate;
			Copy = copy;
		}
	}
}

