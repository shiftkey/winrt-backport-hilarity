using System;
using Windows.Foundation.Metadata;
namespace Windows.Networking.Connectivity
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class ConnectionCost : IConnectionCost
	{
		public extern bool ApproachingDataLimit
		{
			get;
		}
		public extern NetworkCostType NetworkCostType
		{
			get;
		}
		public extern bool OverDataLimit
		{
			get;
		}
		public extern bool Roaming
		{
			get;
		}
	}
}
