using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[ExclusiveTo(typeof(ConnectionCost)), Guid(3134707753u, 13334, 19216, 162, 2, 186, 192, 176, 117, 189, 174), Version(100794368u)]
	internal interface IConnectionCost
	{
		bool ApproachingDataLimit
		{
			get;
		}
		NetworkCostType NetworkCostType
		{
			get;
		}
		bool OverDataLimit
		{
			get;
		}
		bool Roaming
		{
			get;
		}
	}
}
