using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ICC.Data;

namespace ICC.Pages
{
    public partial class HomePageFull : ContentPage
    {
        public HomePageFull()
        {
            InitializeComponent();

            listView.ItemsSource = VideoData.ObservableStringList;
        }
    }
}
