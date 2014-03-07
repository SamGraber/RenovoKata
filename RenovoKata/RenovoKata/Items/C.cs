﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenovoKata.Items
{
	public class C : Item
	{
		const int PRICE = 20;

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
	}
}
