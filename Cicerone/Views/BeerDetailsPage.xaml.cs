using System;
using System.Collections.Generic;
using Cicerone.ViewModels;
using Xamarin.Forms;

namespace Cicerone.Views
{
	[QueryProperty("BeerId", "beerId")]

	public partial class BeerDetailsPage : ContentPage
	{
		BeerDetailViewModel viewModel;

		private string _bid;
		public string BeerId {
			get
			{
				return _bid;
			}
			set
			{
				_bid = value;
			}
		}

		public BeerDetailsPage()
		{
			InitializeComponent();

			
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			BindingContext = viewModel = new BeerDetailViewModel(_bid);

			await viewModel.Init();

			Title = viewModel.BeerInfo.BeerName;
		}
	}
}
