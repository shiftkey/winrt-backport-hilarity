using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(DataPlanUsage)), Guid(3105966381u, 15172, 18431, 179, 97, 190, 89, 230, 158, 209, 176), Version(100794368u)]
	internal interface IDataPlanUsage
	{
		DateTime LastSyncTime
		{
			get;
		}
		uint MegabytesUsed
		{
			get;
		}
	}
}
