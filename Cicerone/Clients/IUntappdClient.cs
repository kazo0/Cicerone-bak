using System;
using System.Threading.Tasks;
using Cicerone.Models;

namespace Cicerone.Clients
{
	public interface IUntappdClient
	{
		Task<BeerSearchResponse> SearchBeers(string query);
	}
}
