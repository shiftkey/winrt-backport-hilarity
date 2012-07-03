using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(StreamSocketListenerControl)), Guid(551077238u, 36234, 19898, 151, 34, 161, 108, 77, 152, 73, 128), Version(100794368u)]
	internal interface IStreamSocketListenerControl
	{
		SocketQualityOfService QualityOfService
		{
			get;
			set;
		}
	}
}
