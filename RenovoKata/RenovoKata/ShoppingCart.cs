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
			aList = new List<A>();
			bList = new List<B>();
			cList = new List<C>();
			dList = new List<D>();
		}

		public List<A> aList { get; set; }
		public List<B> bList { get; set; }
		public List<C> cList { get; set; }
		public List<D> dList { get; set; }

		public int AddItem(Item i)
		{
			int count;

			if (i is A)
			{
				aList.Add(i as A);
				count = aList.Count;
			}
			else if (i is B)
			{
				bList.Add(i as B);
				count = bList.Count;
			}
			else if (i is C)
			{
				cList.Add(i as C);
				count = cList.Count;
			}
			else if (i is D)
			{
				dList.Add(i as D);
				count = dList.Count;
			}
			else
				return 0;

			return i.GetPrice(count);
		}
	}
}
