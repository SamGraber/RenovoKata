using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using RenovoKata.Items;

namespace RenovoKata
{
	public class Cashier
	{
		public Cashier()
		{
			TotalPrice = 0;
			Cart = new ShoppingCart();

			InitializePricesandOffers();
		}

		public void InitializePricesandOffers()
		{
			try
			{
				StreamReader file = new StreamReader("PricesandOffers.txt");

				string beginendChar = file.ReadLine();
				string itemType;
				int numItems;
				int price;
				while (beginendChar != null)
				{
					if (beginendChar == "(")
					{
						itemType = file.ReadLine();
						numItems = Convert.ToInt32(file.ReadLine());

						if (file.Peek() == ')')
						{
							price = numItems;
							numItems = 0;
							Price priceObject = new Price(itemType, price);
							Cart.AddItem(priceObject);
						}
						else
						{
							price = Convert.ToInt32(file.ReadLine());
							beginendChar = file.ReadLine();
							Offer offer = new Offer(itemType, numItems, price);
							Cart.AddItem(offer);
						}
					}

					beginendChar = file.ReadLine();
				}
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("PricesandOffers.txt file not found.", "Error");
			}
		}

		public int TotalPrice { get; set; }
		public ShoppingCart Cart { get; set; }
				
		public int PurchaseItem(string itemID)
		{
			Item i;

			i = CreateItem(itemID);
			
			int cost = Cart.AddItem(i);
			TotalPrice += cost;

			return TotalPrice;
		}

		public Item CreateItem(string itemID)
		{
			switch (itemID)
			{
				case "A":
					return new A();
				case "B":
					return new B();
				case "C":
					return new C();
				case "D":
					return new D();
				default:
					return new Item();
			}
		}

		public void Clear()
		{
			TotalPrice = 0;
			Cart.ClearAll();

			InitializePricesandOffers();
		}
	}
}
