using System.Collections.ObjectModel;
using GeofenceSample.Helpers;
using GeofenceSample.Models;
using GeofenceSample.Views;
using Xamarin.Forms;

namespace GeofenceSample
{
    public partial class App : Application
    {
		public static ObservableCollection<Event> Events = Settings.GetEvents();

		public enum AppState
		{
			Foreground,
			Background
		}

        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();
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
