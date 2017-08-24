using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ICC.Views;

namespace ICC.Pages
{
    public partial class HomePageEmpty : TabbedPage
    {
        //private NoVideosLayout noVideoLayout = new NoVideosLayout();
		//private VideosListLayout videosListLayout = new VideosListLayout();

		public HomePageEmpty()
        {
            InitializeComponent();
        }

        //public static void MyNewMthod()
        //{
           
        //}

        protected override void OnAppearing()
        {
            base.OnAppearing();


            //CrossMediaManager.Current.Play(videoModel.VideoUrl, MediaFileType.Video);
			//Make call through ViewModel to get updated list of videos from Azure Function
			//ViewModel.UpdateVideos()

			//if(ViewMode.Videos.Count <= 0)
			//{
			//    Content = noVideoLayout;
			//}
			//else
			//{
			//    Content = videosListLayout;
			//}

			//videoList.ItemSelected += (obj,e) => {
            //    var videoModel = e.SelectedItem as VideoModel;
			//    CrossMediaManager.Current.Play(videoModel.VideoUrl, MediaFileType.Video);
			//};
		}
    }
}
