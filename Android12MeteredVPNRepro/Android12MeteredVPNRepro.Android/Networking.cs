using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Android12MeteredVPNRepro.Droid
{
    internal class Networking : INetworking
    {
        public bool IsConnectionMetered()
        {
            Activity currentActivity = Xamarin.Essentials.Platform.CurrentActivity;
            Android.Net.ConnectivityManager connectivityManager = (Android.Net.ConnectivityManager)currentActivity.GetSystemService(Android.Content.Context.ConnectivityService);
            bool meteredConnection = connectivityManager.IsActiveNetworkMetered;

            return meteredConnection;
        }
    }
}