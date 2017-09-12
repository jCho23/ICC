using System;
using System.Collections.Generic;
using ICC.Models;
using Xamarin.Forms;
//using ICC.Models;

namespace ICC.Views
{
    public partial class MyCustomViewCell : ViewCell
    {
        public MyCustomViewCell()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var item = BindingContext as VideoData;

            MyLabel.Text = item.MediaAssetName;
        }
    }
}