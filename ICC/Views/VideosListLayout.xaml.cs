﻿//using System;
//using System.Collections.Generic;
//using Plugin.MediaManager;
//using Plugin.MediaManager.Abstractions;
//using Xamarin.Forms;

//namespace ICC.Views
//{
//    public partial class VideosListLayout : ContentPage
//    {
//        private IPlaybackController PlaybackController => CrossMediaManager.Current.PlaybackController;

//        public VideosListLayout()
//        {
//            InitializeComponent();

//			CrossMediaManager.Current.PlayingChanged += (sender, e) =>
//			{
//				Device.BeginInvokeOnMainThread(() =>
//				{
//					ProgressBar.Progress = e.Progress;
//					Duration.Text = "" + e.Duration.TotalSeconds + " seconds";
//				});
//			};

//		}

//		protected override void OnAppearing()
//		{
//			videoView.Source = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4";
//		}

//		void PlayClicked(object sender, System.EventArgs e)
//		{
//			PlaybackController.Play();
//		}

//		void PauseClicked(object sender, System.EventArgs e)
//		{
//			PlaybackController.Pause();
//		}

//		void StopClicked(object sender, System.EventArgs e)
//		{
//			PlaybackController.Stop();
//		}

//    }
//}
