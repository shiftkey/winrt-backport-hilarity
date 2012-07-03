using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(NetworkAdapter)), Guid(995372547u, 21384, 18796, 168, 163, 175, 253, 57, 174, 194, 230), Version(100794368u)]
	internal interface INetworkAdapter
	{
		uint IanaInterfaceType
		{
			get;
		}
		ulong InboundMaxBitsPerSecond
		{
			get;
		}
		Guid NetworkAdapterId
		{
			get;
		}
		NetworkItem NetworkItem
		{
			get;
		}
		ulong OutboundMaxBitsPerSecond
		{
			get;
		}
		IAsyncOperation<ConnectionProfile> GetConnectedProfileAsync();
	}
}
