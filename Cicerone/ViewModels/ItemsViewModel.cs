using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Cicerone.Models;
using Cicerone.Views;
using Cicerone.Services.Contracts;
using Cicerone.Services;

namespace Cicerone.ViewModels
{
	public class ItemsViewModel : BaseViewModel
	{
		private readonly IUntappdService _untappdService;

		public ObservableCollection<BeerItem> Items { get; set; }
		public Command LoadItemsCommand { get; set; }

		public ItemsViewModel()
		{
			Title = "Browse";
			Items = new ObservableCollection<BeerItem>();
			_untappdService = new UntappdService();

		}
	}
}