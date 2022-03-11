# Android12MeteredVPNRepro
On Android 12, connecting to the Private Internet Access (PIA) VPN causes my home wifi network to report as metered. This app is used in demonstrating that issue.

Install this app, connect to PIA VPN, open this app, click Refresh, and note that this app reports the connection as metered.

Disconnect from PIA VPN, go back into this app, click Refresh, and note that this app reports the connection as NOT metered.

## How does the app determine this?

When the Refresh button is clicked, the apps calls the native Android.Net.ConnectivityManager.IsActiveNetworkMetered method.

I made the app open source so that PIA Support can verify this.
