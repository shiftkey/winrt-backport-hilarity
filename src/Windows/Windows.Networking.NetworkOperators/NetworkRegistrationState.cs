using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[Version(100794368u)]
	public enum NetworkRegistrationState
	{
		None,
		Deregistered,
		Searching,
		Home,
		Roaming,
		Partner,
		Denied
	}
}
