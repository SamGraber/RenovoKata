using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenovoKata.Items
{
	public class Offer
	{
		public Offer(string itemType, int numItems, int price)
		{
			ItemType = itemType;
			NumItems = numItems;
			OfferPrice = price;
		}

		public string ItemType { get; set; }

		public int NumItems { get; set; }

		public int OfferPrice { get; set; }
	}
}
