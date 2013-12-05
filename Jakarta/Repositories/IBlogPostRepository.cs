using System;

namespace Jakarta
{
	public interface IBlogPostRepository: IRepository
	{
		BlogPost GetById (int id);
	}
}

