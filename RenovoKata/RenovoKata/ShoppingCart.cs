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
			if (i is A)
				aList.Add(i as A);
			else if (i is B)
				bList.Add(i as B);
			else if (i is C)
				cList.Add(i as C);
			else if (i is D)
				dList.Add(i as D);

			//tally the price of the new item
			return 0;
		}
	}
}
