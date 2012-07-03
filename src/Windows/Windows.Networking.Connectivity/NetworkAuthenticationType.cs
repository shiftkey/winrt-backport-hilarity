using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[Version(100794368u)]
	public enum NetworkAuthenticationType
	{
		None,
		Unknown,
		Open80211,
		SharedKey80211,
		Wpa,
		WpaPsk,
		WpaNone,
		Rsna,
		RsnaPsk,
		Ihv
	}
}
