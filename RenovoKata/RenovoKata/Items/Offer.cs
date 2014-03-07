using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenovoKata.Items
{
	public class Offer
	{
		public Offer(int numItems, int price)
		{
			NumItems = numItems;
			OfferPrice = price;
		}

		public int NumItems { get; set; }

		public int OfferPrice { get; set; }
	}
}
