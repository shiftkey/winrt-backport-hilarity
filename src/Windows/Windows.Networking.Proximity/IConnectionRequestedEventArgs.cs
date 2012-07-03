using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Proximity
{
	[ExclusiveTo(typeof(ConnectionRequestedEventArgs)), Guid(3949498798u, 20254, 19558, 189, 13, 70, 146, 74, 148, 46, 8), Version(100794368u)]
	internal interface IConnectionRequestedEventArgs
	{
		PeerInformation PeerInformation
		{
			get;
		}
	}
}
