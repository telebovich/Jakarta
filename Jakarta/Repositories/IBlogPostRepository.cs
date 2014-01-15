using System;
using Jakarta.Models;

namespace Jakarta
{
	public interface IBlogPostRepository: IRepository<BlogPost>
	{
		BlogPost GetById (int id);
	}
}

