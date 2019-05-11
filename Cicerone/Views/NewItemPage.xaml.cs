using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Cicerone.Models;

namespace Cicerone.Views
{
	public partial class NewItemPage : ContentPage
	{
		public BeerItem Item { get; set; }

		public NewItemPage()
		{
			InitializeComponent();

			Item = new BeerItem
			{
				Text = "Item name",
				Description = "This is an item description."
			};

			BindingContext = this;
		}

		async void Save_Clicked(object sender, EventArgs e)
		{
			MessagingCenter.Send(this, "AddItem", Item);
			await Navigation.PopModalAsync();
		}

		async void Cancel_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopModalAsync();
		}
	}
}