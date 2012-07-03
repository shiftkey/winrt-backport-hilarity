using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[Version(100794368u)]
	public enum NetworkConnectivityLevel
	{
		None,
		LocalAccess,
		ConstrainedInternetAccess,
		InternetAccess
	}
}
