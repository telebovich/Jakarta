using System;
using NUnit.Framework;
using Jakarta.Models;

namespace Jakarta.Tests
{
	[TestFixture]
	public class PortfolioServiceTests
	{
		PortfolioRepository repository = new PortfolioRepository(); 

		public PortfolioServiceTests ()
		{
		}

		[Test]
		public void ShouldReturnListOfPortfolioItemsInRepository()
		{
			var portfolio = repository.GetAll ();
			Assert.GreaterOrEqual (portfolio.Count, 1);
		}
	}
}

