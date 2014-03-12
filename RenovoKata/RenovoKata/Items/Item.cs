using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenovoKata.Items
{
	public class Item
	{
		public Item(string itemType)
		{
			Type = itemType;
		}

		public string Type { get; set; }

		public int Price { get; set; }

		public Offer Offer { get; set; }

		public virtual int GetPrice(int itemNumber)
		{
			if (Offer != null)
			{
				//for every nth item, add the offer price and subtract the price of the previous n - 1 items
				if ((itemNumber % Offer.NumItems) == 0)
				{
					return Offer.OfferPrice - ((Offer.NumItems - 1) * Price);
				}
			}

			return Price;
		}

		public virtual bool IsSameType(Item i)
		{
			return true;
		}

		public virtual bool IsSameType(string s)
		{
			return true;
		}
	}
}
