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

			InitializeOffers();
		}

		public void InitializeOffers()
		{
			try
			{
				StreamReader file = new StreamReader("Offers.txt");

				string itemType = file.ReadLine();
				int numItems;
				int price;
				while (itemType != null)
				{
					numItems = Convert.ToInt32(file.ReadLine());
					price = Convert.ToInt32(file.ReadLine());

					Offer offer = new Offer(itemType, numItems, price);

					Cart.TodayDeals.Add(offer);

					itemType = file.ReadLine();
				}
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("Offers.txt file not found.", "Error");
			}
		}

		public int TotalPrice { get; set; }
		public ShoppingCart Cart { get; set; }
				
		public int PurchaseItem(string itemID)
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

			int cost = Cart.AddItem(i);
			TotalPrice += cost;

			return TotalPrice;
		}

		public void Clear()
		{
			TotalPrice = 0;
			Cart.ClearAll();
		}
	}
}
