using System;
using System.Collections.Generic;
using Jakarta.Models;

namespace Jakarta.Models
{
	public class PortfolioRepository : IPortfolioRepository 
	{
		#region IRepository implementation
		public List<PortfolioItem> GetAll ()
		{
			throw new NotImplementedException ();
		}
		#endregion
	}
}

