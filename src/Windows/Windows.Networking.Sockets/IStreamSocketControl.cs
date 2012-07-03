using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(StreamSocketControl)), Guid(4263882225u, 37547, 19187, 153, 146, 15, 76, 133, 227, 108, 196), Version(100794368u)]
	internal interface IStreamSocketControl
	{
		bool KeepAlive
		{
			get;
			set;
		}
		bool NoDelay
		{
			get;
			set;
		}
		uint OutboundBufferSizeInBytes
		{
			get;
			set;
		}
		byte OutboundUnicastHopLimit
		{
			get;
			set;
		}
		SocketQualityOfService QualityOfService
		{
			get;
			set;
		}
	}
}
