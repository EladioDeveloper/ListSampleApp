using ListSample.View;
using ListSample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PlacesPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
