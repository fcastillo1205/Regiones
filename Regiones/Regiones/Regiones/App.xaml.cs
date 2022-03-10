using Regiones.Services;
using Regiones.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Regiones
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new PageRegiones());
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
