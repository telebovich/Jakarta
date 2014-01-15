using System;
using Jakarta.Models;

namespace Jakarta
{
	public interface IBlogPostService
	{
		BlogPost GetById(int id);
	}
}

