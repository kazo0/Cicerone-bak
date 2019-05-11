using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cicerone.Models;

namespace Cicerone.Services
{
	public class MockDataStore : IDataStore<BeerItem>
	{
		List<BeerItem> items;

		public MockDataStore()
		{
			items = new List<BeerItem>();
			var mockItems = new List<BeerItem>
			{
				new BeerItem { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
				new BeerItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
				new BeerItem { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
				new BeerItem { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
				new BeerItem { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
				new BeerItem { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
			};

			foreach (var item in mockItems)
			{
				items.Add(item);
			}
		}

		public async Task<bool> AddItemAsync(BeerItem item)
		{
			items.Add(item);

			return await Task.FromResult(true);
		}

		public async Task<bool> UpdateItemAsync(BeerItem item)
		{
			var oldItem = items.Where((BeerItem arg) => arg.Id == item.Id).FirstOrDefault();
			items.Remove(oldItem);
			items.Add(item);

			return await Task.FromResult(true);
		}

		public async Task<bool> DeleteItemAsync(string id)
		{
			var oldItem = items.Where((BeerItem arg) => arg.Id == id).FirstOrDefault();
			items.Remove(oldItem);

			return await Task.FromResult(true);
		}

		public async Task<BeerItem> GetItemAsync(string id)
		{
			return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
		}

		public async Task<IEnumerable<BeerItem>> GetItemsAsync(bool forceRefresh = false)
		{
			return await Task.FromResult(items);
		}
	}
}