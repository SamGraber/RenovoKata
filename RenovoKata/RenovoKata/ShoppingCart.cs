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

			TodayDeals = new List<Offer>();
		}

		public List<Item> itemList { get; set; }

		public List<Offer> TodayDeals { get; set; }

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

		public void RemoveItem(Item i)
		{
			itemList.Remove(i);
		}

		public void ClearAll()
		{
			itemList.Clear();
		}
	}
}
