﻿using System;

namespace Jakarta
{
	public class BlogPost
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime CreationDate { get; set; }
		public string Copy { get; set; }
		public string Content { get; set; }
		public int LikesCount { get; set; }
	}
}

