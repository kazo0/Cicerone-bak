using System;

using Cicerone.Models;

namespace Cicerone.ViewModels
{
	public class ItemDetailViewModel : BaseViewModel
	{
		public BeerItem Item { get; set; }
		public ItemDetailViewModel(BeerItem item = null)
		{
			Title = item?.Text;
			Item = item;
		}
	}
}
