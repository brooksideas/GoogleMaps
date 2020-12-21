using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GoogleMaps
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

        private void Search_data_Click(object sender, RoutedEventArgs e)
        {
			string street = txt_street.Text;
			string city = txt_city.Text;
			string state = txt_state.Text;
			string place = txt_place.Text;

			try
			{
				StringBuilder queryaddress = new StringBuilder();

				queryaddress.Append("http://maps.google.com/maps?q=");

				// Street 
				if (street != string.Empty) {
					queryaddress.Append(street + "," + "+");
				}

				// City 

				if (city != string.Empty)
				{
					queryaddress.Append(city + "," + "+");
				}

				//State 

				if (state != string.Empty)
				{
					queryaddress.Append(state + "," + "+");
				}


				//Places

				if (place != string.Empty)
				{
					queryaddress.Append(place + "," + "+");
				}

				// Passing it to the Web Browser 

				MapBrowser.Navigate(queryaddress.ToString());

			}
			catch(Exception ex) { 
				Console.WriteLine(ex.Message.ToString());
			}
        }

         
    }
}
