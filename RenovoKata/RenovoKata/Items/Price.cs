using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenovoKata.Items
{
	public class Price
	{
		public Price(string itemType, int newprice)
		{
			ItemType = itemType;
			price = newprice;
		}

		public string ItemType { get; set; }

		public int price { get; set; }
	}
}
