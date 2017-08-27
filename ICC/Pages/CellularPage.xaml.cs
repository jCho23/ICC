using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICC.Pages
{
    public partial class CellularPage : ContentPage
    {
        public CellularPage()
        {
            InitializeComponent();

			listView.ItemsSource = new List<string>
			{
				"Auto",
				"1080p",
				"720p",
                "480p"
			};
        }

		public ListView Cellular
		{
			get
			{
				return listView;
			}

		}
    }
}
