using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ICC.Views;
using ICC.ViewModels;
using ICC.Services;
using ICC.Models;

namespace ICC.Pages
{
    public partial class HomePage : BaseContentPage<HomePageViewModel>
    {
        private NoVideosLayout noVideoLayout = new NoVideosLayout();
		private VideosListLayout videosListLayout = new VideosListLayout();

		public HomePage()
        {
            InitializeComponent();
        }

		protected override async void OnAppearing()
		{
			base.OnAppearing();

            videosListLayout.ItemSelected += VideoSelected;

			var videos = await VideoHelper.GetAllVideosAsync();

            Device.BeginInvokeOnMainThread(() =>
            {
                if (videos.Count <= 0)
                {
                    Content = noVideoLayout;
                }
                else
                {
                    videosListLayout.ItemsSource = videos;
                    Content = videosListLayout;
                }
            });
		}

		void VideoSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var videoSelected = e.SelectedItem as VideoData;

            if(videoSelected != null)
			    Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(new NativeVideoPlayerPage(videoSelected.MediaAssetUri)));
		}
    }
}
