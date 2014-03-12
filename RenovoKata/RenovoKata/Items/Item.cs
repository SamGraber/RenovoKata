using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RenovoKata.Items
{
	public class Item
	{
		public int Price { get; set; }

		public Offer Offer { get; set; }

		public virtual int GetPrice(int itemNumber)
		{
			return 0;
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
