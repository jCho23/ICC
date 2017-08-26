using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICC.Pages
{
    public partial class WiFiPage : ContentPage
    {
        public WiFiPage()
        {
            InitializeComponent();

			listView.ItemsSource = new List<string>
			{
				"Auto",
				"1080p",
				"720p"
			};
        }

		public ListView WiFi
		{
			get
			{
				return listView;
			}

		}
    }
}
