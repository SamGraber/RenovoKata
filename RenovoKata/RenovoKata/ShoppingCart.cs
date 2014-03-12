﻿using System;
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

		public int AddItem(Item i)
		{
			int count = 0;

			foreach (Offer o in TodayDeals)
			{
				if (i.IsSameType(o.ItemType))
					i.Offer = o;
			}

			itemList.Add(i);

			foreach (Item x in itemList)
			{
				if (i.IsSameType(x))
					count++;
			}

			return i.GetPrice(count);
		}

		public void AddItem(Price price)
		{
			Prices.Add(price);
		}

		public void AddItem(Offer o)
		{
			TodayDeals.Add(o);
		}

		public void RemoveItem(Item i)
		{
			itemList.Remove(i);
		}

		public void RemoveItem(Price price)
		{
			Prices.Remove(price);
		}

		public void RemoveItem(Offer o)
		{
			TodayDeals.Remove(o);
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
