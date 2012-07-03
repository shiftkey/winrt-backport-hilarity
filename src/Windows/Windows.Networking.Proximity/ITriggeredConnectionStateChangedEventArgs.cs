using System;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
namespace Windows.Networking.Proximity
{
	[ExclusiveTo(typeof(TriggeredConnectionStateChangedEventArgs)), Guid(3332866221u, 63201, 19796, 150, 226, 51, 246, 32, 188, 168, 138), Version(100794368u)]
	internal interface ITriggeredConnectionStateChangedEventArgs
	{
		uint Id
		{
			get;
		}
		StreamSocket Socket
		{
			get;
		}
		TriggeredConnectState State
		{
			get;
		}
	}
}
