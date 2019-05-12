using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cicerone.Clients;
using Cicerone.Models;

namespace Cicerone.Services.Untappd
{
	public class UntappdService : IUntappdService
	{
		private readonly IUntappdClient _untappedClient;

		public UntappdService()
		{
			_untappedClient = new UntappdClient();
		}

		public async Task<List<Beer>> SearchBeer(string searchTerm)
		{
			var searchResponse = await _untappedClient.SearchBeers(searchTerm);

			return searchResponse?.Response?.Beers?.Items
				.Select(b => b.Beer)
				.ToList() ?? Enumerable.Empty<Beer>().ToList();
		}
	}
}
