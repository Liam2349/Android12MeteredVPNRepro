using ClassLibrary;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Android12MeteredVPNRepro
{
    public partial class App : Application
    {
        public App(INetworking networking)
        {
            InitializeComponent();

            MainPage = new MainPage(networking);
        }

        private void App_MeteredConnectionChanged(object sender, bool e)
        {
            throw new NotImplementedException();
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
