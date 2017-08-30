using System;
using Xamarin.Forms;
using ICC.ViewModels;

namespace ICC.Pages
{
    public class BaseContentPage<T> : ContentPage where T : BaseViewModel, new()
    {
        T _viewModel;

		public BaseContentPage()
		{
			this.BindingContext = MyViewModel;
		}

		protected T MyViewModel
		{
			get
			{
				return _viewModel ?? (_viewModel = new T());
			}
		}
	}
}
