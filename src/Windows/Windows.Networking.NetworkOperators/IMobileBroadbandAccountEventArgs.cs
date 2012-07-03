using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.NetworkOperators
{
	[ExclusiveTo(typeof(MobileBroadbandAccountEventArgs)), Guid(945014912u, 30686, 19460, 190, 173, 161, 35, 176, 140, 159, 89), Version(100794368u)]
	internal interface IMobileBroadbandAccountEventArgs
	{
		string NetworkAccountId
		{
			get;
		}
	}
}
