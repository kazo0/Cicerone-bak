using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Cicerone.Models;
using Cicerone.Views;
using Cicerone.ViewModels;

namespace Cicerone.Views
{
	public partial class ItemsPage : ContentPage
	{
		BeerSearchViewModel viewModel;

		public ItemsPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new BeerSearchViewModel();
		}
	}
}