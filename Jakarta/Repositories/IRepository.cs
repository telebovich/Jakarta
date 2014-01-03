using System;
using System.Collections.Generic;
using Jakarta.Models;

namespace Jakarta
{
	public interface IRepository<T>
	{
		List<T> GetAll();
	}
}

