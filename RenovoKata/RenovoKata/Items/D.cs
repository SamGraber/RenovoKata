﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenovoKata.Items
{
	public class D : Item
	{
		const int PRICE = 15;

		public override int GetPrice(int itemNumber)
		{
			if (Offer != null)
			{
				if ((itemNumber % Offer.NumItems) == 0)
				{
					return Offer.OfferPrice - ((Offer.NumItems - 1) * PRICE);
				}
			}

			return PRICE;
		}

		public override bool IsSameType(Item i)
		{
			if (i is D)
				return true;
			else
				return false;
		}
	}
}
