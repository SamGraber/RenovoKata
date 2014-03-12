using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RenovoKata.Items;

namespace RenovoKata
{
	public class ShoppingCart
	{
		public ShoppingCart()
		{
			itemList = new List<Item>();
			Prices = new List<Price>();
			TodayDeals = new List<Offer>();
		}

		public List<Item> itemList { get; set; }

		public List<Price> Prices { get; set; }

		public List<Offer> TodayDeals { get; set; }

		#region List Actions

		public int AddItem(Item item)
		{
			int count = 0;

			foreach (Price price in Prices)
			{
				if (item.Type == price.ItemType)
					item.Price = price.price;
			}
			
			foreach (Offer offer in TodayDeals)
			{
				if (item.Type == offer.ItemType)
					item.Offer = offer;
			}

			itemList.Add(item);

			foreach (Item x in itemList)
			{
				if (item.Type == x.Type)
					count++;
			}

			return item.GetPrice(count);
		}

		public void AddItem(Price price)
		{
			Prices.Add(price);
		}

		public void AddItem(Offer offer)
		{
			TodayDeals.Add(offer);
		}

		public void RemoveItem(Item item)
		{
			itemList.Remove(item);
		}

		public void RemoveItem(Price price)
		{
			Prices.Remove(price);
		}

		public void RemoveItem(Offer offer)
		{
			TodayDeals.Remove(offer);
		}

		public void ClearAll()
		{
			itemList.Clear();
			Prices.Clear();
			TodayDeals.Clear();
		}

		#endregion / List Actions
	}
}
