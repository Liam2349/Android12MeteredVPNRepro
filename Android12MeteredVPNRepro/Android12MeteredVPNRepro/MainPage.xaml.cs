using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Android12MeteredVPNRepro
{
    public partial class MainPage : ContentPage
    {
        INetworking networking;
        public MainPage(INetworking networking)
        {
            InitializeComponent();
            this.networking = networking;

            btnRefresh_Clicked(null, null);
        }

        private void btnRefresh_Clicked(object sender, EventArgs e)
        {
            Metered.Text = networking.IsConnectionMetered() ? "Yes" : "No";
        }
    }
}
