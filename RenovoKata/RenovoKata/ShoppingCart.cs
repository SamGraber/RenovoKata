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
		}

		public List<Item> itemList { get; set; }

		public int AddItem(Item i)
		{
			int count = 0;

			itemList.Add(i);

			foreach (Item x in itemList)
			{
				if (i.IsSameType(x))
					count++;
			}

			return i.GetPrice(count);
		}
	}
}
