using ApiTests.Views;
using RestSharp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiTests
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ArtistInfoPage());

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
