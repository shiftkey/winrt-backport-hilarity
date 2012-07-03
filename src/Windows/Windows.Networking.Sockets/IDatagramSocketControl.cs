using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Sockets
{
	[ExclusiveTo(typeof(DatagramSocketControl)), Guid(1387020078u, 13466, 16693, 187, 88, 183, 155, 38, 71, 211, 144), Version(100794368u)]
	internal interface IDatagramSocketControl
	{
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
