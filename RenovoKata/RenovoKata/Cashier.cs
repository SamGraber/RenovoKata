using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RenovoKata.Items;

namespace RenovoKata
{
	public class Cashier
	{
		public void PurchaseItem(string itemID)
		{
			Item i;

			switch (itemID)
			{
				case "A":
					i = new A();
					break;
				case "B":
					i = new B();
					break;
				case "C":
					i = new C();
					break;
				case "D":
					i = new D();
					break;
				default:
					i = new Item();
					break;
			}
		}
	}
}
