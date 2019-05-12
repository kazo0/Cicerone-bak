using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Cicerone.Models;
using Cicerone.Services.Untappd;

namespace Cicerone.ViewModels
{
	public class BeerSearchViewModel : BaseViewModel
	{
		private readonly IUntappdService _untappdService;

		public ObservableCollection<Beer> Beers { get; set; }
		public Command SearchCommand { get; set; }

	 	public BeerSearchViewModel()
		{
			Title = "Search";
			Beers = new ObservableCollection<Beer>();


			_untappdService = new UntappdService();

			SearchCommand = new Command(async () => {
				IsBusy = true;
				var beers = await _untappdService.SearchBeer("Dogfish");
				foreach (var beer in beers)
				{
					Beers.Add(beer);
				}
				IsBusy = false;
			});

		}
	}
}