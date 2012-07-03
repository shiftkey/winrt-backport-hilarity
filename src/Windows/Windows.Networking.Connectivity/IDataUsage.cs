using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(DataUsage)), Guid(3242401235u, 45382, 19769, 185, 89, 12, 105, 176, 150, 197, 18), Version(100794368u)]
	internal interface IDataUsage
	{
		ulong BytesReceived
		{
			get;
		}
		ulong BytesSent
		{
			get;
		}
	}
}
