# About
On Android 12, connecting to the Private Internet Access (PIA) VPN causes my home wifi network to report as metered. This app is used in demonstrating that issue.

Install this app, connect to PIA VPN, open this app, click Refresh, and note that this app reports the connection as metered.

Disconnect from PIA VPN, go back into this app, click Refresh, and note that this app reports the connection as NOT metered.

My understanding is that a change in Android 11 or Android 12 caused this, and that VPN apps need to update in some way to resolve it.

I have personally reproduced this issue on my Galaxy Tab S7+ running One UI 4.0 / Android 12.

## How does the app determine this?

When the Refresh button is clicked, the apps calls the native Android.Net.ConnectivityManager.IsActiveNetworkMetered method.

I made the app open source so that PIA Support can verify this.
