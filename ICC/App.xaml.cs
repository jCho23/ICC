using Xamarin.Forms;
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
            InitializeComponent();

            //MainPage = new NavigationPage(new HomePage());

            //MainPage = new VideosListLayout();

            //new NavigationPage(new HomePage());

            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new NavigationPage(new HomePage()));
            tabbedPage.Children.Add(new SettingsPage());

            MainPage = tabbedPage;

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
