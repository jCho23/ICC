using System;
using Xamarin.Forms;
using Plugin.MediaManager.Forms;

namespace ICC.Pages
{
	public class NativeVideoPlayerPage : ContentPage
	{
		public NativeVideoPlayerPage(string url)
		{
			Title = "Native Video Player";

            Content = new VideoView { Source = url };
		}
	}
}
