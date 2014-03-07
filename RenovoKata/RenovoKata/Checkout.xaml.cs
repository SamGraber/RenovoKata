using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RenovoKata
{
	/// <summary>
	/// Interaction logic for Checkout.xaml
	/// </summary>
	public partial class Checkout : Window
	{
		public Checkout()
		{
			InitializeComponent();

			Cashier = new Cashier();

			DataContext = Cashier;
		}

		public Cashier Cashier { get; set; }

		private void On_Scan_Item(object sender, RoutedEventArgs e)
		{

		}

		private void On_Clear(object sender, RoutedEventArgs e)
		{

		}
	}
}
