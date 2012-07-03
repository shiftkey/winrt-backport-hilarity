using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(HotspotAuthenticationEventDetails)), Guid(3881224081u, 4097, 19941, 131, 199, 222, 97, 216, 136, 49, 208), Version(100794368u)]
	internal interface IHotspotAuthenticationEventDetails
	{
		string EventToken
		{
			get;
		}
	}
}
