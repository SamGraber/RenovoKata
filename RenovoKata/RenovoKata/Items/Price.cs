using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenovoKata.Items
{
	public class Price
	{
		public Price(string itemType, int price)
		{
			ItemType = itemType;
			Price = price;
		}

		public string ItemType { get; set; }

		public int Price { get; set; }
	}
}
