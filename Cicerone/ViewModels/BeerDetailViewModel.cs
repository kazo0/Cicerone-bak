using System;
using System.Threading.Tasks;
using Cicerone.Models;
using Cicerone.Services.Untappd;

namespace Cicerone.ViewModels
{
	public class BeerDetailViewModel : BaseViewModel
	{
		private string _beerId;
		private IUntappdService _untappdService;

		public BeerInfo BeerInfo { get; set; }

		public BeerDetailViewModel(string beerId)
		{
			_beerId = beerId ?? throw new ArgumentNullException(nameof(beerId));
			_untappdService = new UntappdService();
		}

		public async Task Init()
		{
			BeerInfo = await _untappdService.GetBeerInfo(_beerId);
		}
	}
}
