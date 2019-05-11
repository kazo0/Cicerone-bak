using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public class Beer
	{
		[JsonProperty("bid")]
		public int Bid { get; set; }

		[JsonProperty("beer_name")]
		public string BeerName { get; set; }

		[JsonProperty("beer_label")]
		public string BeerLabel { get; set; }

		[JsonProperty("beer_abv")]
		public double BeerAbv { get; set; }

		[JsonProperty("beer_ibu")]
		public int BeerIbu { get; set; }

		[JsonProperty("beer_description")]
		public string BeerDescription { get; set; }

		[JsonProperty("created_at")]
		public string CreatedAt { get; set; }

		[JsonProperty("beer_style")]
		public string BeerStyle { get; set; }

		[JsonProperty("auth_rating")]
		public double AuthRating { get; set; }

		[JsonProperty("wish_list")]
		public bool WishList { get; set; }

		[JsonProperty("in_production")]
		public int InProduction { get; set; }
	}

	public class Contact
	{
		[JsonProperty("twitter")]
		public string Twitter { get; set; }

		[JsonProperty("facebook")]
		public string Facebook { get; set; }

		[JsonProperty("instagram")]
		public string Instagram { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class Location
	{
		[JsonProperty("brewery_city")]
		public string BreweryCity { get; set; }

		[JsonProperty("brewery_state")]
		public string BreweryState { get; set; }

		[JsonProperty("lat")]
		public double Lat { get; set; }

		[JsonProperty("lng")]
		public double Lng { get; set; }
	}

	public class Brewery
	{
		[JsonProperty("brewery_id")]
		public int BreweryId { get; set; }

		[JsonProperty("brewery_name")]
		public string BreweryName { get; set; }

		[JsonProperty("brewery_slug")]
		public string BrewerySlug { get; set; }

		[JsonProperty("brewery_label")]
		public string BreweryLabel { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("contact")]
		public Contact Contact { get; set; }

		[JsonProperty("location")]
		public Location Location { get; set; }

		[JsonProperty("brewery_active")]
		public int BreweryActive { get; set; }
	}



	public class Beers
	{
		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("items")]
		public List<BeerItem> Items { get; set; } = new List<BeerItem>();
	}

	
}