using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(HotspotAuthenticationContext)), Guid(3881224081u, 4098, 19941, 131, 199, 222, 97, 216, 136, 49, 208), Version(100794368u)]
	internal interface IHotspotAuthenticationContextStatics
	{
		bool TryGetAuthenticationContext([In] string evenToken, out HotspotAuthenticationContext context);
	}
}
