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
			var _list = new List<PortfolioItem> { 
				new PortfolioItem {
					Id = 1, Image = "~/Content/images/prod_thumb.png", 
					Title = "Job Name", Description = "Lorem ipsum dolor sit amet, " +
						"consectetur adipiscing elit. Aenean vel ligula vel felis pretium gravida..."
				},
				new PortfolioItem {
					Id = 1, Image = "~/Content/images/prod_thumb.png", 
					Title = "Job Name", Description = "Lorem ipsum dolor sit amet, " +
						"consectetur adipiscing elit. Aenean vel ligula vel felis pretium gravida..."
				},
				new PortfolioItem {
					Id = 1, Image = "~/Content/images/prod_thumb.png", 
					Title = "Job Name", Description = "Lorem ipsum dolor sit amet, " +
						"consectetur adipiscing elit. Aenean vel ligula vel felis pretium gravida..."
				}
			};
			return _list;
		}
		#endregion
	}
}

