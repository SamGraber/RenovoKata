﻿using System;
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

					Cart.AddItem(offer);

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

			InitializeOffers();
		}
	}
}
