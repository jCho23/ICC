using System;
using System.Collections.Generic;

using Xamarin.Forms;

using ICC.ViewModels;

namespace ICC.Pages
{
    public partial class SettingsPage : BaseContentPage<SettingsViewModel>
    {
        void OnWiFi(object sender, System.EventArgs e)
		{
            var page = new WiFiPage();
            page.WiFi.ItemSelected += (source, args) =>
			{
				wiFi.Text = args.SelectedItem.ToString();
				Navigation.PopAsync();
			};

			Navigation.PushAsync(page);
		}

        void OnCellular(object sender, System.EventArgs e)
        {
			var page = new CellularPage();
			page.Cellular.ItemSelected += (source, args) =>
			{
                cellular.Text = args.SelectedItem.ToString();
				Navigation.PopAsync();
			};

			Navigation.PushAsync(page);
        }

		public SettingsPage()
        {
            InitializeComponent();
        }
    }
}
