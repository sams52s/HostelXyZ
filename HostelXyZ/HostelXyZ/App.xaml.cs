using HostelXyZ.LoginRegistration.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HostelXyZ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AllUser());
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
