﻿using Xamarin.Forms;
using ICC.Pages;
using ICC.Views;
using Plugin.MediaManager.Forms;
using Xamarin.Forms.Xaml;

namespace ICC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            var workaround = typeof(VideoView);

            InitializeComponent();

            //MainPage = new NavigationPage(new HomePage());

            MainPage = new VideosListLayout2();

            //new NavigationPage(new HomePage());

            //var tabbedPage = new TabbedPage();
            //tabbedPage.Children.Add(new HomePage());
            //tabbedPage.Children.Add(new SettingsPage());

            //MainPage = tabbedPage;

            //var home = new HomePageEmpty();

            //HomePageEmpty.MyNewMthod(home);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
