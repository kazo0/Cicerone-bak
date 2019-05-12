using System;
using System.Collections.Generic;
using Cicerone.Views;
using Xamarin.Forms;

namespace Cicerone
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute("beerDetails", typeof(BeerDetailsPage));
		}
	}
}
