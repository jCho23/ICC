using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ICC.Views;
using ICC.ViewModels;

namespace ICC.Pages
{
    public partial class HomePage : BaseContentPage<HomePageViewModel>
    {
        //private NoVideosLayout noVideoLayout = new NoVideosLayout();
		//private VideosListLayout videosListLayout = new VideosListLayout();

		public HomePage()
        {
            //VideoViewRenderer.Init()
                             
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
