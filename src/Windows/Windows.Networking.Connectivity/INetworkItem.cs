using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(NetworkItem)), Guid(29117753u, 62944, 17767, 162, 140, 66, 8, 12, 131, 27, 43), Version(100794368u)]
	internal interface INetworkItem
	{
		Guid NetworkId
		{
			get;
		}
		NetworkTypes GetNetworkTypes();
	}
}
