using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[Version(100794368u)]
	public sealed class HotspotAuthenticationEventDetails : IHotspotAuthenticationEventDetails
	{
		public extern string EventToken
		{
			get;
		}
	}
}
