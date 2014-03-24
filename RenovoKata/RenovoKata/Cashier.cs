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

				string itemType = file.ReadLine();
				int price;
				int numItems;
				int offerPrice;
				while (itemType != null)
				{
					price = Convert.ToInt32(file.ReadLine());
					numItems = Convert.ToInt32(file.ReadLine());
					offerPrice = Convert.ToInt32(file.ReadLine());

					Price priceObject = new Price(itemType, price);
					Cart.AddItem(priceObject);

					if (numItems != 0)
					{
						Offer offer = new Offer(itemType, numItems, offerPrice);
						Cart.AddItem(offer);
					}

					itemType = file.ReadLine();
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
			Item item;

			item = new Item(itemID);
			
			int cost = Cart.AddItem(item);
			TotalPrice += cost;

			return TotalPrice;
		}

		public void Clear()
		{
			TotalPrice = 0;
			Cart.ClearAll();

			InitializePricesandOffers();
		}
	}
}
