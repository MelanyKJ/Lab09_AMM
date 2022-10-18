using Lab09.Services;
using Lab09.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab09
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new EjemploCSS();
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
