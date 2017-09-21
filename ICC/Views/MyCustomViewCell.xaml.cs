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

            //TODO: ORIGINAL
			MyLabel.Text = item.title;
			
            //TODO: IDENTIFYING BUG
            if(MyLabel.Text!=null)
            {
                MyLabel.Text = item.title;
            }
        }
    }
}